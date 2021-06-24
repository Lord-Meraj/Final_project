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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
            //List<client> clients = new List<client>();
            


        }
        public class client
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }
            public int age { get; set; }
        }



        private void NewForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = $"User : {CurentUser.UserName}";
            lblRoleName.Text = $"Role : {CurentUser.RoleName}";

            if (CurentUser.RoleName != "admin")
            {
                modiriat.Enabled = false;
                //modiriat.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
