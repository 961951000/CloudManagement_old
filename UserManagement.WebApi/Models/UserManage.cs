using System;
using System.Security.Principal;
using UserManagement.Data.Models;

namespace UserManagement.WebApi.Models
{
    public class UserManage : IIdentity
    {
        public User User { get; }
        public UserManage(User user)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
        }
        public string Name => User.UserName;

        public string AuthenticationType => "Basic";

        public bool IsAuthenticated => true;
    }
}