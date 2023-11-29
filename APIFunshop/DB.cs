using APIFunshop.DataBaseFolder;

namespace APIFunshop
{
    public class DB
    {
        public DB() { }

        static FunshopContext instanse;
        public static FunshopContext GetDB()
        {
            if (instanse == null)
                instanse = new FunshopContext();
            return instanse;
        }
    }
}
