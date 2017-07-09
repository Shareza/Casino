using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casino
{
    public class Spinners
    {
        private string first { get; set; }
        private string second { get; set; }
        private string third { get; set; }

        public Dictionary<int, string> firstSpinnerDictionary = new Dictionary<int, string>();
        public Dictionary<int, string> secondSpinnerDictionary = new Dictionary<int, string>();
        public Dictionary<int, string> thirdSpinnerDictionary = new Dictionary<int, string>();

        public Spinners()
        {
            InitializeFirstSpinner();
            InitializeSecondSpinner();
            InitializeThirdSpinner();
        }

        public void InitializeFirstSpinner()
        {
            firstSpinnerDictionary.Add(0, @"Models/Bar.png");
            firstSpinnerDictionary.Add(1, @"Models/cherry.png");
            firstSpinnerDictionary.Add(2, @"Models/seven.png");
            firstSpinnerDictionary.Add(3, @"Models/star.png");
            firstSpinnerDictionary.Add(4, @"Models/strawberry.png");
            firstSpinnerDictionary.Add(5, @"Models/watermelon.png");
        }

        public void InitializeSecondSpinner()
        {
            secondSpinnerDictionary.Add(0, @"Models/Bar.png");
            secondSpinnerDictionary.Add(1, @"Models/cherry.png");
            secondSpinnerDictionary.Add(2, @"Models/seven.png");
            secondSpinnerDictionary.Add(3, @"Models/star.png");
            secondSpinnerDictionary.Add(4, @"Models/strawberry.png");
            secondSpinnerDictionary.Add(5, @"Models/watermelon.png");
        }

        public void InitializeThirdSpinner()
        {
            thirdSpinnerDictionary.Add(0, @"Models/Bar.png");
            thirdSpinnerDictionary.Add(1, @"Models/cherry.png");
            thirdSpinnerDictionary.Add(2, @"Models/seven.png");
            thirdSpinnerDictionary.Add(3, @"Models/star.png");
            thirdSpinnerDictionary.Add(4, @"Models/strawberry.png");
            thirdSpinnerDictionary.Add(5, @"Models/watermelon.png");
        }
    }
}