﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto
{
    public partial class LottoDashboard : Form
    {
        public SelectionNumbers select = new SelectionNumbers();
        private List<int> generateRandomNumbersToList = new List<int>();
        private List<int> generateDrawnNumbersToList = new List<int>();

        private decimal totalCash = 50;
        private int totalDrawns = 0;
        private const int betCash = 3;
        private int hitTheNumbers = 0;
        private const long minimumJackpot = 1000000;
        private const long maximumJackpot = 37500000;
        private decimal jackpot;

        public LottoDashboard()
        {
            InitializeComponent();
        }
        #region jackpot
        private string GenerateJackpot()
        {
            Random randomMoney = new Random();
            string totalJackpot = randomMoney.NextInt64(minimumJackpot, maximumJackpot).ToString();
            bool correctJackpot = decimal.TryParse(totalJackpot, out jackpot);
            return jackpot.ToString("C2");
        }
        #endregion
        #region generate numbers
        private void GenerateRandomNumbers()
        {
            Random randomNumbers = new Random();
            while (generateRandomNumbersToList.Count != 6)
            {
                int number = randomNumbers.Next(1, 49);
                if (generateRandomNumbersToList.Contains(number))
                {
                    continue;
                }
                else
                {
                    generateRandomNumbersToList.Add(number);
                }
            }
            number_1.Text = generateRandomNumbersToList[0].ToString();
            number_2.Text = generateRandomNumbersToList[1].ToString();
            number_3.Text = generateRandomNumbersToList[2].ToString();
            number_4.Text = generateRandomNumbersToList[3].ToString();
            number_5.Text = generateRandomNumbersToList[4].ToString();
            number_6.Text = generateRandomNumbersToList[5].ToString();
        }

        private void GenerateDrawnNumbers()
        {
            //Random drawnNumbers = new Random();
            //while (generateDrawnNumbersToList.Count != 6)
            //{
            //    int number = drawnNumbers.Next(1, 49);
            //    if (generateDrawnNumbersToList.Contains(number))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        generateDrawnNumbersToList.Add(number);
            //    }
            //}
            generateDrawnNumbersToList.Add(5);
            generateDrawnNumbersToList.Add(15);
            generateDrawnNumbersToList.Add(25);
            generateDrawnNumbersToList.Add(35);
            generateDrawnNumbersToList.Add(1);
            generateDrawnNumbersToList.Add(7);

            drawn_numbers_1.Text = generateDrawnNumbersToList[0].ToString();
            drawn_numbers_2.Text = generateDrawnNumbersToList[1].ToString();
            drawn_numbers_3.Text = generateDrawnNumbersToList[2].ToString();
            drawn_numbers_4.Text = generateDrawnNumbersToList[3].ToString();
            drawn_numbers_5.Text = generateDrawnNumbersToList[4].ToString();
            drawn_numbers_6.Text = generateDrawnNumbersToList[5].ToString();
        }
        #endregion
        private void StartDrawnLotto()
        {
            GenerateDrawnNumbers();
            totalDrawns += 1;
            total_drawns.Text = totalDrawns.ToString();
            totalCash -= betCash;
            total_cash.Text = totalCash.ToString("C2");
            VeryficationWins();
            start_game_button.Enabled = false;
            again_button.Visible = true;
            quit_game_button.Visible = true;
        }

        private void VeryficationWins()
        {
            if (select.startGameSelectionNumbers)
            {
                for (int i = 0; i < generateDrawnNumbersToList.Count; i++)
                {
                    int number = select.numbersSelected[i];
                    if (generateDrawnNumbersToList.Contains(number))
                    {
                        hitTheNumbers += 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < generateDrawnNumbersToList.Count; i++)
                {
                    int number = generateRandomNumbersToList[i];
                    if (generateDrawnNumbersToList.Contains(number))
                    {
                        hitTheNumbers += 1;
                    }
                }
            }
            WinnersMoneyCalculation();
        }
        private DialogResult WinnerMessage(decimal money)
        {
            return MessageBox.Show($"Hit numbers: {hitTheNumbers} numbers, your winners is {money.ToString("C2")}", "Winner",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal Win()
        {
            decimal calc = (6 + totalDrawns) * hitTheNumbers;
            return jackpot / calc;
        }

        private void WinnersMoneyCalculation()
        {
            //decimal calc = (6 + totalDrawns) * hitTheNumbers;
            if (hitTheNumbers < 3)
            {
                MessageBox.Show("Sorry not this time. You haven't hit enough numbers.", "Winner", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (hitTheNumbers == 3)
            {
                WinnerMessage(Win());
            }
            else if (hitTheNumbers == 4)
            {
                WinnerMessage(Win());
            }
            else if (hitTheNumbers == 5)
            {
                WinnerMessage(Win());
            }
            else
            {
                MessageBox.Show($"Congratilation you hit the: {hitTheNumbers} numbers, you wan a jackpot {jackpot}", "Winner",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LottoDashboard_Shown(object sender, EventArgs e)
        {
            jackpot_money.Text = GenerateJackpot();
            total_cash.Text = totalCash.ToString("C2");
            if (select.startGameSelectionNumbers)
            {
                number_1.Text = select.numbersSelected[0].ToString();
                number_2.Text = select.numbersSelected[1].ToString();
                number_3.Text = select.numbersSelected[2].ToString();
                number_4.Text = select.numbersSelected[3].ToString();
                number_5.Text = select.numbersSelected[4].ToString();
                number_6.Text = select.numbersSelected[5].ToString();
            }
            else
            {
                GenerateRandomNumbers();
            }
        }

        private void start_game_button_Click(object sender, EventArgs e)
        {
            StartDrawnLotto();
        }

        private void quit_game_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void again_button_Click(object sender, EventArgs e)
        {
            if (select.startGameSelectionNumbers)
            {
                if (MessageBox.Show("Do you want select new numbers", "New numbers", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               DialogResult.Yes)
                {
                    select.numbersSelected.Clear();
                    select = new SelectionNumbers();
                    select.ShowDialog();
                    number_1.Text = select.numbersSelected[0].ToString();
                    number_2.Text = select.numbersSelected[1].ToString();
                    number_3.Text = select.numbersSelected[2].ToString();
                    number_4.Text = select.numbersSelected[3].ToString();
                    number_5.Text = select.numbersSelected[4].ToString();
                    number_6.Text = select.numbersSelected[5].ToString();
                    hitTheNumbers = 0;
                    quit_game_button.Visible = false;
                    again_button.Visible = false;
                    start_game_button.Enabled = true;
                    GenerateJackpot();
                }
                else
                {
                    ResetGameRandomNumbers();
                    GenerateJackpot();
                }
            }
            else
            {
                if (MessageBox.Show("Do you want to draw new numbers", "New numbers", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               DialogResult.Yes)
                {
                    generateRandomNumbersToList.Clear();
                    GenerateRandomNumbers();
                    ResetGameRandomNumbers();
                    GenerateJackpot();
                }
                else
                {
                    ResetGameRandomNumbers();
                    GenerateJackpot();
                }
            }
        }

        private void ResetGameRandomNumbers()
        {
            hitTheNumbers = 0;
            quit_game_button.Visible = false;
            again_button.Visible = false;
            drawn_numbers_1.Text = 0.ToString();
            drawn_numbers_2.Text = 0.ToString();
            drawn_numbers_3.Text = 0.ToString();
            drawn_numbers_4.Text = 0.ToString();
            drawn_numbers_5.Text = 0.ToString();
            drawn_numbers_6.Text = 0.ToString();
            generateDrawnNumbersToList.Clear();
            start_game_button.Enabled = true;
        }

        private void LottoDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (select.CloseWindowMessage() == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Dispose();
            }
        }
    }
}
