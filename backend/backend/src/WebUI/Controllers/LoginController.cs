using DocumentFormat.OpenXml.Spreadsheet;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;
using Microsoft.AspNetCore.Authorization;
using CommonReadModels.Contracts;
using backend.Application.ApplicationUsers.Queries.GetUserByUserNameAndPassword;
using MediatR;

namespace WebUI.Controllers;

[ApiController]
[Route("/api/[Controller]")]
public class LoginController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IMediator _mediator;

    public LoginController(IConfiguration configuration, IMediator mediator)
    {
        _configuration = configuration;
        _mediator = mediator;
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
    {
        var user = await _mediator.Send(new GetByUsernameAndPasswordQuery() { Password = request.Password, Username = request.Email });
        if (user == null)
        {
            return Unauthorized();
        }
        var claims = new Claim[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim(JwtRegisteredClaimNames.Exp, DateTime.UtcNow.AddHours(5).ToString()),
                        new Claim("id", $"{user.Id}"),
                        new Claim("Email", request.Email),
                        new Claim("Role", ((int)user.Role).ToString()),

            };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            _configuration["Jwt:Issuer"],
            _configuration["Jwt:Audience"],
            claims,
            expires: DateTime.UtcNow.AddDays(5),
            signingCredentials: signIn);
        var responseObject = new
        {
            access_token = new JwtSecurityTokenHandler().WriteToken(token),
            user = user
        };
        return Ok(responseObject);
    }
    [HttpGet]
    public  IActionResult GetCurrentUser()
    {
        var g = HttpContext.User.Claims.Select(x => x.Type).ToList();
        var user = new 
        { 
            id = HttpContext.User.Claims.Where(x => x.Type == "id").Select(x=> int.Parse(x.Value)).SingleOrDefault(),
            email = HttpContext.User.Claims.Where(x => x.Type == "Email").Select(x => x.Value).SingleOrDefault(),
            role= HttpContext.User.Claims.Where(x => x.Type == "Role").Select(x => int.Parse(x.Value)).SingleOrDefault(),


        };
        
        
        return Ok(user);
    }
}
