﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton(object sender, RoutedEventArgs e)
        {
            Game game = new Game(Game.AmoutOfPlayers);

        }

        public void EnterField_TextChanged(object sender, TextChangedEventArgs e)
        {
            string result = "";
            foreach (char item in EnterField.Text)
            {
                if (char.IsNumber(item))
                    result += item;
            }
            EnterField.Text = result;

            Game.AmoutOfPlayers = Convert.ToInt32(result);
        }
    }
}
