using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Name == txtName.Text.Trim() && x.Password == txtPassword.Text);
            NewForm newForm = new NewForm();
                if (user != null)
                {
                    CurentUser.RoleName = user.RoleName;
                    CurentUser.UserName = user.Name;
                    switch (user.RoleName)
                    {
                        case "admin":
                        newForm.Show();

                            break;
                        case "user":
                        newForm.Show();
                            break;

                        default:
                            MessageBox.Show("ورود نا معتبر","خطا");
                            break;
                    }
                }                
            }

        }


    }
}
