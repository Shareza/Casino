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
        private int bet = 1;
        private int credits;
        private int win = 0;

        static Random rng = new Random();
        Spinners InitCasino = new Spinners();

       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                firstSpinnerImage.ImageUrl = @"Models/bar.png";
                secondSpinnerImage.ImageUrl = @"Models/cherry.png";
                thirdSpinnerImage.ImageUrl = @"Models/seven.png";

                credits = 100;
                ViewState["credits"] = credits;

                bet = 1;
                ViewState["bet"] = bet;
            }

        }

        protected void spinButton_Click(object sender, EventArgs e)
        {
            myCashLabel.Text = ViewState["credits"].ToString();
            credits = Int32.Parse(ViewState["credits"].ToString());
            credits = credits - Convert.ToInt32(ViewState["bet"]);
            ViewState["credits"] = credits;


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
            betLabel.Text = ViewState["bet"].ToString();
            bet = Int32.Parse(ViewState["bet"].ToString());
            ++bet;
            ViewState["bet"] = bet;
        }

        public void UpdateBalance()
        {
            myCashLabel.Text = credits.ToString();
        }

        public void GameLogic()
        {
            if (firstSpinnerImage.ImageUrl == @"Models/cherry.png" &&
                secondSpinnerImage.ImageUrl == @"Models/cherry.png")
            {
                credits += 2;
                currentWinLabel.Text = "You win 2";
            }
        }
    }
}