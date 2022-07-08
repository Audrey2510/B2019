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
    /// Interaction logic for ProfileSignInPage.xaml
    /// </summary>
    public partial class ProfileSignInPage : Page
    {

        public ProfileSignInPage()
        {
            InitializeComponent();
            _back.transitionPageButton.Click += Back_Click;

            _back.initAppearance(TransitionPageButton.Orientation.BACK, "BACK");

            Hyperlink link = new Hyperlink();
            link.IsEnabled = true;
            link.TextDecorations = null;
            link.Inlines.Add("Forgot Password?");
            link.Click += forgotPass;
            _forgotPass.Inlines.Add(link);
        }

        public string conString = "Data Source=DESKTOP-E1TR2T0\\SQLEXPRESS;Initial Catalog=RMS_DB_1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void forgotPass(object sender, RoutedEventArgs e)
        {
            // password stuff here
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            int index = GlobalData.Instance.accountList.IndexOf(UserInput.Text);

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("insert into signin values('" + UserInput.Text + "','" + PasswordInput.Password + "')", con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully logged in");

            }

            else
            {
                _name.Foreground = Brushes.Red;
                _pass.Foreground = Brushes.Red;
                invalidInput.Text = "Invalid username or password";
               
            }

           

        }

        private void UserInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            invalidInput.Text = "";
            _name.Foreground = Brushes.Black;
            _pass.Foreground = Brushes.Black;
        }

        private void PasswordInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            invalidInput.Text = "";
            _pass.Foreground = Brushes.Black;
            _name.Foreground = Brushes.Black;
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ProfilePage1 profilepage1 = new ProfilePage1();
            this.NavigationService.Navigate(profilepage1);

        }

    }
}
