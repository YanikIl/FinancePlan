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
using System.Windows.Shapes;

namespace FinancePlan
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {

            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Password.Trim();

            if (login.Length < 2)
            {
                textBoxLogin.ToolTip = "Это поле введено не корректно!";
            }
            else if (password.Length < 3)
            {
                textBoxPassword.ToolTip = "Это поле введено не корректно!";
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxPassword.ToolTip = "";

                User authUser = null;
                using(ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show("Все хoрошо");
                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Hide();
                }
                else
                {

                    MessageBox.Show("Ошибка в введенных данных");
                }
            }

        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow  = new MainWindow();
            mainWindow.Show();
            Hide();

        }

    }
}
