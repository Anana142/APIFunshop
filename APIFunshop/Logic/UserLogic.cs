using APIFunshop.DataBaseFolder;
using APIFunshop.DTO;
using APIFunshop.Helper;

namespace APIFunshop.Logic
{
    public class UserLogic
    {
        public static List<User> GetAllUsers()
        {
            return DB.GetDB().Users.ToList();
        }

        public static void AddUser(User user)
        {
            DB.GetDB().Users.Add(user);
            DB.GetDB().SaveChanges();
        }

    }
}
