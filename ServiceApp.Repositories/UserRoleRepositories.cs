using ServiceApp.Entities;
using ServiceApp.Entities.Models;
using ServiceApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Repositories
{
    public class UserRoleRepositories: RepositoryBase<UserRole,ServiceAppQDbContext>,IUserRoleRepositories
    {
        public UserRoleRepositories(ServiceAppQDbContext ServiceAppContext)
            : base(ServiceAppContext) { 
        }
    }
}
