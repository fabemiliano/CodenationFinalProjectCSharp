using System;
using System.Collections.Generic;
using System.Linq;
using CodenationFinalProject.Models;

namespace CodenationFinalProject.Repository
{
    public class UsersRepository : BaseRepository<Users>, IUsers
    {
        public UsersRepository(Context context) : base(context)
        {

        }

        public Users getByEmail(string email)
        {
            return context.Users.FirstOrDefault(x => x.Email == email);
        }

    }
}
