using ExampleofOOP.Modells.Entities.Concrete;
using ExampleofOOP.Modells.Enums;
using ExampleofOOP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleofOOP.Repositories.Concrete
{
    public class AppUserRepository : IBaseRepository<AppUser>, IAppUserRepository
    {
        public void Create(AppUser entity)
        {
            FakeData.AppUsers.Add(entity);
        }

        public void Delete(Guid id)
        {
            foreach (AppUser user in FakeData.AppUsers.ToList())
            {
                if (user.Id == id)
                {
                    FakeData.AppUsers.Remove(user);
                    break;
                }
            }
        }

        public AppUser GetById(Guid id)
        {
            foreach (AppUser user in FakeData.AppUsers.ToList())
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null;
        }

        public List<AppUser> GetByRole(Role role)
        {
            List<AppUser> users = new List<AppUser>();

            foreach (AppUser user in FakeData.AppUsers.ToList())
            {
                if (user.Role == role)
                {
                    users.Add(user);
                }
            }

            return users;
        }

        public void GetRoles(ComboBox comboBox)
        {
            comboBox.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBox.SelectedIndex = 0;
        }

        public List<AppUser> Gets()
        {
            return FakeData.AppUsers.ToList();
        }

        public void Update(AppUser entity)
        {
            foreach (AppUser user in FakeData.AppUsers.ToList())
            {
                if (entity.Id == user.Id)
                {
                    user.FirstName = entity.FirstName;
                    user.LastName = entity.LastName;
                    user.UserName = entity.Password;
                    user.Status = Modells.Enums.Status.Modified;
                    user.Role = entity.Role;
                    user.Status = Status.Modified;
                }
            }
        }
    }
}