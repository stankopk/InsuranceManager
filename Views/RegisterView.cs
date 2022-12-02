using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceManager.View
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text != null && PasswordTxt.Text != null)
            {
                try
                {
                    Connect obj = new Connect();
                    obj.conn.ConnectionString = obj.locate;
                    obj.conn.Open();
                    string insertUser = "insert into usersTable values ('"+UsernameTxt.Text+"', '"+PasswordTxt.Text+"')";
                    obj.cmd.Connection = obj.conn;
                    obj.cmd.CommandText = insertUser;
                    obj.cmd.ExecuteNonQuery();
                    obj.conn.Close();
                    MessageBox.Show("Registration has been completed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoginView lv = new LoginView();
            lv.Show();
            this.Hide();
        }
    }
}
