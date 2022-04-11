using ExampleofOOP.Modells.Entities.Concrete;
using ExampleofOOP.Modells.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleofOOP.Repositories.Interfaces
{
    public interface IAppUserRepository
    {
        void Create(AppUser entity);
        void Update(AppUser entity);
        void Delete(Guid id);

        void GetRoles(ComboBox combobox);
        AppUser GetById(Guid id);
        List<AppUser> GetByRole(Role role);
    }
}
