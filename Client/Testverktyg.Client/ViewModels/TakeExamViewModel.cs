﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testverktyg.Client.Services;
using Testverktyg.Client.Models;
using System.ServiceModel.Description;
using Windows.UI.Popups;

namespace Testverktyg.Client.ViewModels
{
    class TakeExamViewModel
    {
        private static TakeExamViewModel instance;
        public Question question { get; set; }
        public ObservableCollection<Question> Questions;

        public static TakeExamViewModel Instance
        { get { if (instance == null)
                    instance = new TakeExamViewModel();
                    return instance;
              }
        }

        private TakeExamViewModel()
        {
            question = new Question();
            Questions = new ObservableCollection<Question>();
        }
            
        public async void QuestionsInTest()
        {
            try
            {
                List<Question> temp = await ExamService.GetExamQuestionsAsync();
                foreach(Question question in temp)
                {
                    Questions.Add(question);
                }
                
            }
            catch(System.Net.Http.HttpRequestException ex)
            {
                await new MessageDialog($"{ex.Message}\nDatabase error").ShowAsync();
            }
        }
        

    }
}
