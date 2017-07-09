using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Casino
{
    public partial class Default : System.Web.UI.Page
    {
        static Random rng = new Random();
        private int bet = 1;
        private int credits = 30;
        Spinners InitCasino = new Spinners();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                firstSpinnerImage.ImageUrl = @"Models/bar.png";
                secondSpinnerImage.ImageUrl = @"Models/cherry.png";
                thirdSpinnerImage.ImageUrl = @"Models/seven.png";
                myCashLabel.Text = credits.ToString();
            }
            else
            {
                UpdateBalance();
            }
            
            //betLabel.Text = tempBet.ToString();
        }

        protected void spinButton_Click(object sender, EventArgs e)
        {
            credits--;
            myCashLabel.Text = credits.ToString();

            int firstSpinnerKey = rng.Next(6);
            int secondSpinnerKey = rng.Next(6);
            int thirdSpinnerKey = rng.Next(6);

            string firstSpinnerValue = string.Empty;
            string secondSpinnerValue = string.Empty;
            string thirdSpinnerValue = string.Empty;

            InitCasino.firstSpinnerDictionary.TryGetValue(firstSpinnerKey, out firstSpinnerValue);
            InitCasino.secondSpinnerDictionary.TryGetValue(secondSpinnerKey, out secondSpinnerValue);
            InitCasino.secondSpinnerDictionary.TryGetValue(thirdSpinnerKey, out thirdSpinnerValue);

            firstSpinnerImage.ImageUrl = firstSpinnerValue;
            secondSpinnerImage.ImageUrl = secondSpinnerValue;
            thirdSpinnerImage.ImageUrl = thirdSpinnerValue;

        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            //bet++;
            //betLabel.Text = bet.ToString();
            
        }

        public void UpdateBalance()
        {
            myCashLabel.Text = credits.ToString();
        }
    }
}