using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systest_saince.api.ViewModels;

namespace systest_saince.repo.Services
{
    public interface IRegistrationRepo
    {
        Task<UserRegistration> AddUser(UserRegistration userRegistration);
    }
}
