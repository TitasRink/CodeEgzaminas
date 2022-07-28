using Bussiness.AccesssData;
using FrameworkData.DataContext;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LogIn : Form
    {
        private string LogName { get; set; } = string.Empty;
        private string Password { get; set; } = string.Empty;

        UserService user = new UserService();
       
        public static int UserID { get; set; }



        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            LogName = UserLogin.Text;
            Password = PasswordLogin.Text;

            var result = true;

            if (string.IsNullOrEmpty(LogName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Fill fiellds");
                result = user.LoginUser(LogName, Password);

            }
            else
            {
                if (result)
                {
                    UserID = user.ReturnIDUser(LogName);
                    if(UserID == 0)
                    {
                        MessageBox.Show("No user with this name");
                    }
                    else
                    {
                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                   
                }
                else
                {
                    UserLogin.Text = "";
                    PasswordLogin.Text = "";
                    return;
                }
            }
        }

        private void CreatUserBuutton_Click(object sender, EventArgs e)
        {
            LogName = UserLogin.Text;
            Password = PasswordLogin.Text;
            var result = user.UserAlreadyExists(LogName);

            if (string.IsNullOrEmpty(LogName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Fill fiellds");

            }
            if (result)
            {
                MessageBox.Show("User allready exists");
                UserLogin.Text = "";
                PasswordLogin.Text = "";
            }
            else
            {
                user.CreatUser(LogName, Password);
                MessageBox.Show("User created");
                
                return;
            }
        }
    }
}
