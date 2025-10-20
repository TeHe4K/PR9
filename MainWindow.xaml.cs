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
using PR9.Classes;

namespace PR9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Wars wars;
        private WarsLightArmor warsLightArmor;
        private WarsHeavyArmor warsHeavyArmor;
        public MainWindow()
        {
            InitializeComponent();
            InitializeWar();
        }
        private void InitializeWar()
        {
            wars = new Wars(100);
            warsLightArmor = new WarsLightArmor(100 , 0.50);
            warsHeavyArmor = new WarsHeavyArmor(100, 0.75);
            UpdateHealthDisplay();
        }
        private void UpdateHealthDisplay()
        {
            NoShield.Content = "Здоровье: " + wars.Health;
            lightShield.Content = "Здоровье: " + warsLightArmor.Health;
            HeavyShield.Content = "Здоровье: " + warsHeavyArmor.Health;
        }

        private void NoArmor(object sender, RoutedEventArgs e)
        {
            wars.damage(45);
            NoShield.Content = "Здоровье: " + wars.Health;
            if (wars.Health <= 0)
            {
                (sender as Button).IsEnabled = false;
                wars.Health = 0;
                UpdateHealthDisplay();
            }
        }

        private void LightArmor(object sender, RoutedEventArgs e)
        {
            warsLightArmor.damage(45);
            lightShield.Content = "Здоровье: " + warsLightArmor.Health;
            if(warsLightArmor.Health <= 0)
            {
                (sender as Button).IsEnabled = false;
                warsLightArmor.Health = 0;
                UpdateHealthDisplay();
            }
        }

        private void HeavyArmor(object sender, RoutedEventArgs e)
        {
            warsHeavyArmor.damage(45);
            HeavyShield.Content = "Здоровье: " + warsHeavyArmor.Health;
            if(warsHeavyArmor.Health <= 0)
            {
                (sender as Button).IsEnabled = false;
                warsHeavyArmor.Health = 0;
                UpdateHealthDisplay();
            }
        }
    }
}
