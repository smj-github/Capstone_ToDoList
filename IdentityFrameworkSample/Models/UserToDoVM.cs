using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityFrameworkSample.Models
{
    public class UserToDoVM
    {
        public AspNetUsers LoginUser { get; set; }
        public List<Todo> TodoList { get; set; }

        public UserToDoVM(AspNetUsers LoginUser, List<Todo> TodoList)
        {
            this.LoginUser = LoginUser;
            this.TodoList = TodoList;
        }

        public UserToDoVM(AspNetUsers LoginUser)
        {
            this.LoginUser = LoginUser;
        }
        public UserToDoVM() { }
    }
}
