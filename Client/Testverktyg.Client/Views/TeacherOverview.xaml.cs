﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Testverktyg.Client.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Testverktyg.Client.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TeacherOverview : Page
    {
        private Teacher _teacher;

        public TeacherOverview()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _teacher = (Teacher)e.Parameter;
        }

        private void CreateTestButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Remove1Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CorrectTestButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReUseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Remove2Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
