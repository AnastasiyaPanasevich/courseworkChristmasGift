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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChristmasGiftClient.Controller
{
    /// <summary>
    /// Interaction logic for SelectWindow.xaml
    /// </summary>
    public partial class SelectWindow : Window
    {
        public SelectWindow()
        {
            InitializeComponent();
        }

        private void btnCreateCustom_Click(object sender, RoutedEventArgs e)
        {
            CreateOrderWindow createOrderWindow = new CreateOrderWindow();
            createOrderWindow.Show();
            

            this.Close();

        }

        private void btnCreateRandom_Click(object sender, RoutedEventArgs e)
        {
            RandomWindow randomWindow = new RandomWindow();
            randomWindow.Show();

            this.Close();

        }
    }
}
