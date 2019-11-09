using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class AuthRepository
    {
        private ArtDataContext<IdentityUser> db;
        public AuthRepository(ArtDataContext<IdentityUser> context)
        {
            db = context;
        }

        public async Task<AuthHistory> CreateUserHistory(IdentityUser user)
        {

            var userHistory = new AuthHistory { Token = user.Id, UserName = user.UserName };
             List<AuthHistory> newList = db.AuthHistories.ToList();
            newList.Add(userHistory);
            
            using (db)
            {
                db.AuthHistories.AddRange(newList);
                db.SaveChanges();
            }
            return userHistory;
        }




    }
}
