using Carter;
using FluentResults;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Api.Commons.Base
{
    public abstract class BaseModule : CarterModule
    {
        protected IResult HandleRequest<TRequest>(Result<TRequest> result) {

            if(result == null) {
                return Results.NotFound("Object Not Found");
            }
            if(result.IsFailed) {
                return Results.BadRequest(result.Errors);
            }
            

            return Results.Ok(result.Value);
        }

     
    }
}