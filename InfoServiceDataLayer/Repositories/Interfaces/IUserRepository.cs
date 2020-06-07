using InfoServiceDataLayer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace InfoServiceDataLayer.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public List<IUser> Get(int idUser);

        public int Insert(IUser newUser);

        public bool Update(IUser newUser);
    }
}
