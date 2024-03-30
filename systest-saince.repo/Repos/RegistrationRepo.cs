using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systest_saince.api.ViewModels;
using systest_saince.repo.Services;

namespace systest_saince.repo.Repos
{
    public class RegistrationRepo :IRegistrationRepo
    {
        
        public async Task<UserRegistration> AddUser(UserRegistration userRegistration)
        {
            //need to call the DB to insert and update the data 

            return null;
        }
    }
}
