using System;
namespace RentTogetherWebApp.Interfaces.Business
{
    public interface IUserService
    {
        void CreateUser();

        void GetUser();

        void UpdateUser();

        void DeleteUser();
    }
}
