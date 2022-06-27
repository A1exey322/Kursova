using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Entity;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly ApplicationDbContext _db;

        public List<PhoneBySlug> listdevices = new List<PhoneBySlug>();

        public  User curuser;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<User> GetAll()
        {
            return _db.Users;
        }

        public async Task Delete(User entity)
        {
            _db.Users.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Create(User entity)
        {
            await _db.Users.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<User> Update(User entity)
        {
            _db.Users.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }


        public void AddDevice(PhoneBySlug phoneBySlug, long Id)
        {


            curuser = _db.Users.Where(user => user.Id == Id).First();

            if(curuser.Liked != null)
            {
                listdevices = JsonSerializer.Deserialize<List<PhoneBySlug>>(curuser.Liked);
            }

            var isContain = (from i in listdevices
                             where i.data == phoneBySlug.data
                             select i).Count() > 0;

            if (!isContain)
            {
                listdevices.Add(phoneBySlug);
            }
            deviceSerialize();
            _db.SaveChanges();
        }


        private void deviceSerialize()
        {
            if (listdevices == null) listdevices = new();
            curuser.Liked = JsonSerializer.Serialize(listdevices.ToArray());
        }
    }
}

