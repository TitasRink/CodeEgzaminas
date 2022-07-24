namespace Bussiness.AccesssData
{
    public interface IUserService
    {
        void CreatUser(string name, string password);
        bool LoginUser(string name, string pasword);
        int ReturnIDUser(string user);
    }
}