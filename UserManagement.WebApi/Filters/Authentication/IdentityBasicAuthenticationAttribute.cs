using System.Data.Entity;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using UserManagement.Data.Models;
using UserManagement.WebApi.DatabaseContext;
using UserManagement.WebApi.Models;

namespace UserManagement.WebApi.Filters.Authentication
{
    public class IdentityBasicAuthenticationAttribute : BasicAuthenticationAttribute
    {
        protected override async Task<IPrincipal> AuthenticateAsync(string userName, string password, CancellationToken cancellationToken)
        {
            using (var db = new SqlServerContext())
            {
                if (await db.User.AnyAsync(x => x.UserName == userName && x.Password == password, cancellationToken))
                {
                    return await Task.Run(() => new ClaimsPrincipal(new UserManage(new User { UserName = userName, Password = password })), cancellationToken);
                }
            }

            return null;
        }
    }
}