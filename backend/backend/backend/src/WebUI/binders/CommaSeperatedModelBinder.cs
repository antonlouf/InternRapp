using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebUI.binders;

public class CommaSeperatedModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {

       var idList= bindingContext.HttpContext.Request.Query.Keys.SingleOrDefault(x => x.Contains("Ids"));
        if (idList!=null)
        {
            //bindingContext.Model = idList.Split(",").Select(x => int.Parse(x));

            bindingContext.Result = ModelBindingResult.Success(idList.Split(",").Select(x => int.Parse(x)));
        }
        return Task.CompletedTask;
    }
}
