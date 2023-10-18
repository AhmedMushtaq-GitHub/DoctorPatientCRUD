using DoctorCRUD.Data;
using DoctorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorCRUD.Repository.Implementation
{
    public class UserAccountRepository : IUserAccount
    {
        private readonly DoctorDbContext _db;
        public UserAccountRepository(DoctorDbContext db)
        {
                _db = db;
        }
        public string Register(User user)
        {
            user.UserRolesId = 1;
            user.IsConfirmed = false;
            user.JoinedOn = DateTime.UtcNow.AddHours(5);
            user.AccessToken = Guid.NewGuid().ToString() + DateTime.UtcNow.Ticks;
            _db.users.Add(user);
            _db.SaveChanges();
            return user.AccessToken + user.JoinedOn.Ticks.ToString();
        }
    }
}
