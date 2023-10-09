using NewSysAcad.Business;
using NewSysAcad.Business.Impl;
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
        private UserService _userSrvc;
        public LoginForm() {
            InitializeComponent();
            _userSrvc = new UserServiceImpl();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void LbExitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e){
            Response resp = null;
            User user;
            try {
                user = new User();
                user.Name = TXUserName.Text;
                user.Password = TXPassword.Text;

                resp = _userSrvc.CreateUser(user);
                MessageBox.Show(resp.Message);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
