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

namespace Sity
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddCity();
        }

        private void AddNumbers()
        {
            Numbers num = new Numbers { CityName = TextBox1.Text, Number = TextBox2.Text, Coment = TextBox3.Text };
            using (CityContext context = new CityContext())
            {
                context.Number.Add(num);
                context.SaveChanges();
            }
            MessageBox.Show("Номер добавлен в базу");
        }

        private void AddCity()
        {
            using (CityContext context = new CityContext())
            {
                Cityes city1 = new Cityes { Name = "Алматы", Code = "727" };
                Cityes city2 = new Cityes { Name = "Актау", Code = "7292" };
                Cityes city3 = new Cityes { Name = "Атырау", Code = "7122" };
                Cityes city4 = new Cityes { Name = "Актобе", Code = "7132" };
                Cityes city5 = new Cityes { Name = "Кокшетау", Code = "7162" };
                Cityes city6 = new Cityes { Name = "Караганда", Code = "7212" };
                Cityes city7 = new Cityes { Name = "Костанай", Code = "7142" };
                Cityes city8 = new Cityes { Name = "Кызылорда", Code = "72422" };
                Cityes city9 = new Cityes { Name = "Нурсултан", Code = "7172" };
                Cityes city10 = new Cityes { Name = "Павлодар", Code = "7182" };
                Cityes city11 = new Cityes { Name = "Петропавловск", Code = "7152" };
                Cityes city12 = new Cityes { Name = "Тараз", Code = "7262" };
                Cityes city13 = new Cityes { Name = "Талдыкорган", Code = "7282" };
                Cityes city14 = new Cityes { Name = "Усть-Каменогорск", Code = "7232" };
                Cityes city15 = new Cityes { Name = "Уральск", Code = "7112" };
                Cityes city16 = new Cityes { Name = "Шымкент", Code = "7252" };

                context.City.Add(city1);
                context.City.Add(city2);
                context.City.Add(city3);
                context.City.Add(city4);
                context.City.Add(city5);
                context.City.Add(city6);
                context.City.Add(city7);
                context.City.Add(city8);
                context.City.Add(city9);
                context.City.Add(city10);
                context.City.Add(city11);
                context.City.Add(city12);
                context.City.Add(city13);
                context.City.Add(city14);
                context.City.Add(city15);
                context.City.Add(city16);
                context.SaveChanges();

                var city = context.City;
                List<Cityes> cityes = new List<Cityes>();
                
                foreach (var i in context.City)
                {
                    cityes.Add(i);
                }

                ListBox1.ItemsSource = cityes;
            }
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBox1.Text = ListBox1.SelectedItem.ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AddNumbers();
        }
    }
}
