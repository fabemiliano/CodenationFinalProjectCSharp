using System;
using CodenationFinalProject.Models;

namespace CodenationFinalProject.Repository
{
    public interface IUsers : IBaseInterface<Users>
    {
        public Users getByEmail(string email);
    }

}
