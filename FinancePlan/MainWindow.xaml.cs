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

namespace FinancePlan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ApplicationContext db; //объект подключенный к базе данных

        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();   //ссылка на класс контекста

            //List<User> users = db.Users.ToList();  //вытягивает записи и преобразует в список
            //string str = "";
            //foreach (User user in users)
            //    str += "Login: " + user.Login + "   ";  //кладем польхзователей в строку

            //exampleText.Text = str;
        }




        private void Button_Registr_Click(object sender, RoutedEventArgs e)
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

                MessageBox.Show("Все хoрошо");


                User user = new User(login, password);  //создаем объект 


                db.Users.Add(user); //добавляем в БД
                db.SaveChanges(); //сoхраняем настройки


                AuthorizationWindow authorizationWindow = new AuthorizationWindow();
                authorizationWindow.Show();
                Hide();
            }
        }


        private void Button_Authorization_Window_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Hide();
        }
    }
}
