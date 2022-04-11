using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleofOOP
{
    public static class Utilities
    {
        public static void Eraser(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
            }
        }

        public static Guid GetDataFromDataGridView(DataGridView dataGridView,
                                                   TextBox txtId,
                                                   TextBox txtFirstName,
                                                   TextBox txtLastName,
                                                   TextBox txtUserName,
                                                   TextBox txtPassword)
        {
            Guid id = Guid.Parse(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
            txtId.Text = id.ToString();
            txtFirstName.Text = dataGridView.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLastName.Text = dataGridView.CurrentRow.Cells["LastName"].Value.ToString();
            txtUserName.Text = dataGridView.CurrentRow.Cells["UserName"].Value.ToString();
            txtPassword.Text = dataGridView.CurrentRow.Cells["Password"].Value.ToString();
            txtId.Enabled = false;
            return id;
        }
    }
}
