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
using ConsoleApp1;

namespace FinancePlan
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        List<Card> card;
        public UserPageWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Card n = (Card)ListView.SelectedItem;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtBalance.Text)) 
            
                return;

            int bal = Convert.ToInt32(txtBalance.Text);
            string nam = txtName.Text;

            card = new List<Card>();

            card.Add(new Card(bal, nam));
            
            ListView.ItemsSource = card;
            
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
