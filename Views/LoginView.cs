using InsuranceManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceManager
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text != null && txtBoxPassword.Text != null)
            {
                try
                {
                    Connect obj = new Connect();
                    obj.conn.ConnectionString = obj.locate;

                    obj.conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT (*) FROM usersTable  where username = '"+txtBoxUsername.Text+"' and  password = '"+txtBoxPassword.Text+"' ", obj.conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        HomeView hv = new HomeView();
                        hv.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Incorrect account details");
                    }

                    obj.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No empty fields are allowed");
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            RegisterView rv = new RegisterView();
            rv.Show();
            this.Hide();   
        }
    }
}
