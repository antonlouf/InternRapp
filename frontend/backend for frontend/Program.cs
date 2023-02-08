using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
.AddMicrosoftIdentityWebApp(options => builder.Configuration.GetSection("AzureAdB2C").Bind(options), options =>
{
    
    options.Cookie.Name = "bff";
    options.Cookie.SameSite = SameSiteMode.None;
    options.Cookie.HttpOnly = Convert.ToBoolean(HttpOnlyPolicy.None);
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
})
.EnableTokenAcquisitionToCallDownstreamApi()
//.AddDownstreamWebApi("T", builder.Configuration.GetSection("T"))
.AddDistributedTokenCaches();
//builder.Services.AddStackExchangeRedisCache(options =>
//{
//    options.Configuration = builder.Configuration.GetConnectionString("Redis");
//    options.InstanceName = "t";
//});


builder.Services.AddControllers(options =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    options.Filters.Add(new AuthorizeFilter(policy));
  
    //options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
}).AddMicrosoftIdentityUI();
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});
builder.Services.AddCors();
builder.Services.AddHealthChecks();
// In production, the Angular files will be served from this directory

var app = builder.Build();
app.UseStaticFiles();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{

    
    app.UseSpaStaticFiles();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(builder =>
{
    builder.WithOrigins(
        "https://migrationtestb2c.b2clogin.com/migrationtestb2c.onmicrosoft.com/b2c_1_singup_signin/oauth2/v2.0/authorize?client_id=f448d875-975b-4506-a82a-fb0b1f928ce8&redirect_uri=https%3A%2F%2Flocalhost%3A44403%2Fsignin-oidc&response_type=code&scope=openid%20profile%20offline_access&code_challenge=x0fWCW2IXrFpxp4_ogot0l1IIrXyu5R8g4tAdWE1Gk0&code_challenge_method=S256&response_mode=form_post&nonce=638114586990749715.M2JkNDJkYTctMDcxZC00NTFhLThmNTctOTUxYmY2YzEwYjU5ZjgzN2QyYWQtOTA1YS00NGI0LWJiMWYtZGZiZmNhZTljNTZl&client_info=1&x-client-brkrver=IDWeb.1.26.0.0&state=CfDJ8OlMY_vgTpdLtuRQAp_mmROW9DCkUN6NxC_Cjo3jlQCCGwzaQVvmDp1aGPr8Df9XaxufIkf7r_2opIW8AUYH93JDIQg62KTIrNoiuY1_DYnwiWc6CnDldk5mQF3FFzb-Umdgr41r9Bqk3NlLWQP7xHtJUbibodlbA4UQplGHTJkIr7LjfcKgFl2HUnodsvdtOQf-9aurNEVMn909chyOJyTDPCt_2pk0HtAv415f9KC3rTCj35-byM3HN0RC_c2NwPdk_ljWy8yLyO_Vz_VLv4GEz3ZgEZZiIpCs69FhUvHxPvemhnbr0qX20tIO0WMhluP-w1HpHNZh8lEPLLt03V2y3Md70558kf1i5dEi5hUqkHgdcF3N-toFNPegY5qF_EV_eZZ_ZHKYDsDm2joJqUU&x-client-SKU=ID_NET6_0&x-client-ver=6.25.1.0",
        "https://localhost:44403").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");


app.Use(async (context, next) =>
{

    if (context.User.Identity == null)
    {
        await context.ChallengeAsync(OpenIdConnectDefaults.AuthenticationScheme);

    }
    await next();
});

app.UseWhen(x => x.User!=null&&x.User.Identity!=null&&x.User.Identity.IsAuthenticated, builder =>
{
    app.UseSpa(spa =>
    {
        spa.Options.SourcePath = "ClientApp/dist";

        
    });
    
});



app.Run();
