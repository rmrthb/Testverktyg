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
    public sealed partial class SplitViewMenu : Page
    {
        private Teacher _teacher;

        public SplitViewMenu()
        {
            this.InitializeComponent();
        }

        private void CollapseButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuSplit.IsPaneOpen)
            {
                MenuSplit.IsPaneOpen = false;
                CollapseButton.Width = 54;
            }
            else
            {
                MenuSplit.IsPaneOpen = true;
                CollapseButton.Width = 128;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _teacher = (Teacher)e.Parameter;
            PageFrame.Navigate(typeof(TeacherOverview), _teacher);
        }

        private void SplitViewMenuList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(CreateQuestionListBoxitem.IsSelected)
            {
                PageFrame.Navigate(typeof(CreateQuestion), _teacher);
                TitleTextblock.Text = "Skapa fråga";
            }
            else if(CreateExamListBoxitem.IsSelected)
            {
                PageFrame.Navigate(typeof(CreateExam), _teacher);
                TitleTextblock.Text = "Skapa prov";
            }
            else if(HomeListBoxItem.IsSelected)
            {
                PageFrame.Navigate(typeof(TeacherOverview), _teacher);
                TitleTextblock.Text = "Välkommen";
            }

            else if(CorrectExamListBoxItem.IsSelected)
            {
                PageFrame.Navigate(typeof(CorrectExam));
                TitleTextblock.Text = "Rätta prov";

            }
            else if(ExitListBoxitem.IsSelected)
            {
                _teacher = null;
                this.Frame.Navigate(typeof(MainPage));
            }
        }
    }
}
