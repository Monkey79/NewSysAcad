using NewSysAcad.Business;
using NewSysAcad.Business.Dto;
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
        private NewSysAcadMainForm _mainForm;

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
            UserDto userDto;
            try {
                userDto = new UserDto();
                userDto.UserName = TXUserName.Text;
                userDto.Password = TXPassword.Text;

                userDto = _userSrvc.GetUserByCredential(userDto);
                if (userDto.LoginStatus.Equals(UserDto.OK)){
                    _mainForm = new NewSysAcadMainForm();                    
                    _mainForm.LogedUser = userDto;
                    _mainForm.Show();
                    this.Hide();
                }else if (userDto.LoginStatus.Equals(UserDto.ERROR)) {
                    MessageBox.Show(userDto.LoginMssg);
                }               
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e){

        }

        private void label1_Click(object sender, EventArgs e){
            TXUserName.Clear(); 
            TXPassword.Clear();
        }
    }
}
