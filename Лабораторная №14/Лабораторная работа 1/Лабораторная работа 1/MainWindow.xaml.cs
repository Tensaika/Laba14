﻿using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Лабораторная_работа_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<Button, Action> ButEff = new Dictionary<Button, Action>();
        public MainWindow()
        {
            InitializeComponent();
            ConfigureButtonEffects();
        }
        private void ConfigureButtonEffects()
        {
            ButEff.Add(MagicButton , () => ButEffMagic(MagicButton)) ;
            ButEff.Add(Energybutton, () => ButEffEnergy(Energybutton));
        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (ButEff.ContainsKey(button))
            {
                ButEff[button].Invoke();
            }
        }
        public void ButEffMagic(Button button)
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            button.Background = new SolidColorBrush(color);

        }
        public void ButEffEnergy(Button button)
        {
            button.Width *= 1.1;
            button.Height *= 1.1;
        }
    }
}
