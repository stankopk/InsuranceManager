using InsuranceManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            RegisterView rv = new RegisterView();
            rv.Show();
            this.Hide();   
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
