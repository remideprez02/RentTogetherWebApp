using System;
using RentTogetherWebApp.Interfaces.Dal;

namespace RentTogetherWebApp.Business
{
    /// <summary>
    /// User service.
    /// Service métier pour les interractions/objets User.
    /// </summary>
    public class UserService : IDal
    {
        //Utilisation de l'injection de dépendances via l'interface IDal
        private readonly IDal _dal;
        public UserService(IDal dal)
        {
            _dal = dal;
        }

        public void CreateUser(){
            
        }

        public void GetUser(){
            
        }

        public void UpdateUser(){
            
        }

        public void DeleteUser(){
            
        }
    }
}
