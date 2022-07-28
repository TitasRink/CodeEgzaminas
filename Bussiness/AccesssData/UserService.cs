
using FrameworkData.DataContext;
using FrameworkData.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bussiness.AccesssData

{
    public class UserService : IUserService
    {
        public DataConection context = new DataConection();



        public void CreatUser(string name, string password)
        {

            User dep = new User(name, password);
            context.Users.Add(dep);
            context.SaveChanges();
        }

        public bool LoginUser(string name, string pasword)
        {
            var user = context.Users.Where(x => x.Name == name && x.Password == pasword).FirstOrDefault();
            if (user == null )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int ReturnIDUser(string user)
        {
            var iscreated = context.Users.Any(x => x.Name == user);
            if (iscreated)
            {
                var r = context.Users.Where(x => x.Name == user).FirstOrDefault().Id;
                return r;
            }
            else
            {
                return 0;
            }
          
        }

        public bool UserAlreadyExists(string name)
        {
            var user = context.Users.Select(x => x.Name == name).FirstOrDefault();
            return user;
        }
    }
}
