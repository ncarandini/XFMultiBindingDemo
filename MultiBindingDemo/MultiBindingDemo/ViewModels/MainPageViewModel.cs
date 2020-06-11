using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBindingDemo.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        bool conditionA = false;
        public bool ConditionA
        {
            get => conditionA;
            set => SetProperty(ref conditionA, value, onChanged: () =>
            {
                OnPropertyChanged(nameof(ConditionAandB));
            });
        }

        bool conditionB = true;
        public bool ConditionB
        {
            get => conditionB;
            set => SetProperty(ref conditionB, value, onChanged: () =>
            {
                OnPropertyChanged(nameof(ConditionAandB));
            });
        }

        public bool ConditionAandB => ConditionA && ConditionB;
    }
}
