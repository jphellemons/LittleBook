using System.Collections.Generic;
using LittleBook.Models;

namespace LittleBook.Models{
    public class ManageUsersViewModel{
        public IEnumerable<ApplicationUser> Administrators {get;set;}
        public IEnumerable<ApplicationUser> Everyone {get;set;}
    }
}