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
        private const long minimumJackpot = 1000000;
        private const long maximumJackpot = 37500000;
        private decimal jackpot;

        public LottoDashboard()
        {
            InitializeComponent();
        }
        #region jackpot
        private decimal GenerateJackpot()
        {
            Random randomMoney = new Random();
            string totalJackpot = randomMoney.NextInt64(minimumJackpot, maximumJackpot).ToString("C2");
            jackpot_money.Text = totalJackpot;
            bool correctJackpot = decimal.TryParse(totalJackpot, out jackpot);
            return jackpot;
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
            Random drawnNumbers = new Random();
            while (generateDrawnNumbersToList.Count != 6)
            {
                int number = drawnNumbers.Next(1, 49);
                if (generateDrawnNumbersToList.Contains(number))
                {
                    continue;
                }
                else
                {
                    generateDrawnNumbersToList.Add(number);
                }
            }
            drawn_numbers_1.Text = generateDrawnNumbersToList[0].ToString();
            drawn_numbers_2.Text = generateDrawnNumbersToList[1].ToString();
            drawn_numbers_3.Text = generateDrawnNumbersToList[2].ToString();
            drawn_numbers_4.Text = generateDrawnNumbersToList[3].ToString();
            drawn_numbers_5.Text = generateDrawnNumbersToList[4].ToString();
            drawn_numbers_6.Text = generateDrawnNumbersToList[5].ToString();
        }
        #endregion
        private void LottoDashboard_Shown(object sender, EventArgs e)
        {
            GenerateDrawnNumbers();
            GenerateJackpot();
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
            //to-do
        }

        private void quit_game_button_Click(object sender, EventArgs e)
        {
            //to-do
        }

        private void again_button_Click(object sender, EventArgs e)
        {
            //to-do
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
