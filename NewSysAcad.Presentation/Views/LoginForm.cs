using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSysAcad.Presentation.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbExitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e){
            User user;
            try { 


            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
