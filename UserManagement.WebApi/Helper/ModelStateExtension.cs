using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace UserManagement.WebApi.Helper
{
    public static class ModelStateExtension
    {
        public static IEnumerable<string> ExpendErrors(this ModelStateDictionary modelState)
        {
            var query = from state in modelState.Values
                        from error in state.Errors
                        select error.Exception;
            if (query.Any())
            {
                query.AsParallel().ForAll(ex => Logger.Error(ex));
            }
            return (from item in modelState.Values from error in item.Errors where item.Errors.Count > 0 select error.ErrorMessage).ToList();
        }
    }
}