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

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmPassLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            LoginView lv = new LoginView();
            lv.Show();
            this.Hide();
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPassTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
