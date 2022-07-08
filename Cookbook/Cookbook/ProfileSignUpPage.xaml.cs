using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Cookbook
{
    /// <summary>
    /// Interaction logic for ProfileSignUpPage.xaml
    /// </summary>
    public partial class ProfileSignUpPage : Page
    {

        public ProfileSignUpPage()
        {
            InitializeComponent();
            _back.transitionPageButton.Click += Back_Click;

            _back.initAppearance(TransitionPageButton.Orientation.BACK, "BACK");
        }

        public string conString = "Data Source=DESKTOP-E1TR2T0\\SQLEXPRESS;Initial Catalog=RMS_DB_1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (nameInput.Text == "" || emailInput.Text == "" || passwordInput.Password.Length == 0)
            {
                if (nameInput.Text == "")
                {
                    nameText.Foreground = Brushes.Red;
                }
                if (emailInput.Text == "")
                {
                    emailText.Foreground = Brushes.Red;
                }
                if (passwordInput.Password.Length == 0)
                {
                    passText.Foreground = Brushes.Red;
                }
                
                invalidInput.Text = "Highlighted field(s) are required.";
            }
            else if (nameInput.Text.Length < 4)
            {
                invalidInput.Text = "Username needs to be at least 4 characters.";
                nameText.Foreground = Brushes.Red;

            }
            else if (passwordInput.Password.Length < 8)
            {
                invalidInput.Text = "Password needs to be at least 8 characters.";
                passText.Foreground = Brushes.Red;

            }
            else if (!(passwordInput.Password.Contains("1") || passwordInput.Password.Contains("2") || passwordInput.Password.Contains("3") || passwordInput.Password.Contains("4") || passwordInput.Password.Contains("5") || passwordInput.Password.Contains("6") || passwordInput.Password.Contains("7") || passwordInput.Password.Contains("8") || passwordInput.Password.Contains("9") || passwordInput.Password.Contains("0")))
            {
                invalidInput.Text = "Password needs to contain at least 1 digit.";
                passText.Foreground = Brushes.Red;
            }
            else
            {
                ProfileMainPage profileMainPage = new ProfileMainPage(nameInput.Text, emailInput.Text, passwordInput.Password);
                GlobalData.Instance.signedIn = true;
                GlobalData.Instance.accountList.Add(nameInput.Text);
                GlobalData.Instance.accountList.Add(emailInput.Text);
                GlobalData.Instance.accountList.Add(passwordInput.Password);
                GlobalData.Instance.accountList.Add("");
                GlobalData.Instance.accountList.Add("");
                signUpMain.Content = profileMainPage;

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("insert into signup values('" + nameInput.Text + "','" + emailInput.Text + "','" + passwordInput.Password + "')", con);
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connection Made successfully!!");

                }
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ProfilePage1 profilepage1 = new ProfilePage1();
            this.NavigationService.Navigate(profilepage1);

        }

        private void UserInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            invalidInput.Text = "";
            nameText.Foreground = Brushes.Black;
            emailText.Foreground = Brushes.Black;
            passText.Foreground = Brushes.Black;
        }

        private void EmailInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            invalidInput.Text = "";
            nameText.Foreground = Brushes.Black;
            emailText.Foreground = Brushes.Black;
            passText.Foreground = Brushes.Black;
        }

        private void PasswordInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            invalidInput.Text = "";
            nameText.Foreground = Brushes.Black;
            emailText.Foreground = Brushes.Black;
            passText.Foreground = Brushes.Black;
        }

        private void signUpMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
