using System;
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
        public LottoDashboard()
        {
            InitializeComponent();
        }

        public SelectionNumbers select = new SelectionNumbers();

        private List<int> randomNumbersPlayer = new List<int>();
        private List<int> drawingNumbers = new List<int>();

        private decimal totalCash = 50;
        private int totalDraws = 0;
        private int totalWins = 0;
        private const int betCash = 3;
        private int hitTheNumbers = 0;
        private const long minimumJackpot = 1000000;
        private const long maximumJackpot = 37500000;
        private decimal jackpot;

        private string GenerateJackpot()
        {
            Random randomMoney = new Random();
            string totalJackpot = randomMoney.NextInt64(minimumJackpot, maximumJackpot).ToString();
            decimal correctJacpot = decimal.Parse(totalJackpot);
            jackpot = correctJacpot;
            return jackpot.ToString("C2");
        }
        private void GenerateRandomNambersForPlayes()
        {
            Random randomNumbers = new Random();
            while (randomNumbersPlayer.Count != 6)
            {
                int number = randomNumbers.Next(1, 49);
                if (randomNumbersPlayer.Contains(number))
                {
                    continue;
                }
                else
                {
                    randomNumbersPlayer.Add(number);
                }
            }
            number_1.Text = randomNumbersPlayer[0].ToString();
            number_2.Text = randomNumbersPlayer[1].ToString();
            number_3.Text = randomNumbersPlayer[2].ToString();
            number_4.Text = randomNumbersPlayer[3].ToString();
            number_5.Text = randomNumbersPlayer[4].ToString();
            number_6.Text = randomNumbersPlayer[5].ToString();
        }
        private void GenerationOfDrawingNumbers()
        {
            Random drawnNumbers = new Random();
            while (drawingNumbers.Count != 6)
            {
                int number = drawnNumbers.Next(1, 49);
                if (drawingNumbers.Contains(number))
                {
                    continue;
                }
                else
                {
                    drawingNumbers.Add(number);
                }
            }

            drawn_numbers_1.Text = drawingNumbers[0].ToString();
            drawn_numbers_2.Text = drawingNumbers[1].ToString();
            drawn_numbers_3.Text = drawingNumbers[2].ToString();
            drawn_numbers_4.Text = drawingNumbers[3].ToString();
            drawn_numbers_5.Text = drawingNumbers[4].ToString();
            drawn_numbers_6.Text = drawingNumbers[5].ToString();
        }
        private void VeryficationOfTheNumbersHit()
        {
            if (select.startGameSelectionNumbers)
            {
                for (int i = 0; i < drawingNumbers.Count; i++)
                {
                    int number = select.numbersSelected[i];
                    if (drawingNumbers.Contains(number))
                    {
                        hitTheNumbers += 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < drawingNumbers.Count; i++)
                {
                    int number = randomNumbersPlayer[i];
                    if (drawingNumbers.Contains(number))
                    {
                        hitTheNumbers += 1;
                    }
                }
            }
            InformationOnWinning();
        }
        private decimal CalculationOfWinnings()
        {
            decimal calc = (6 + totalDraws) * hitTheNumbers;
            return jackpot / calc;
        }
        private DialogResult MessagesOfWinnings(decimal money)
        {
            return MessageBox.Show($"Hit numbers: {hitTheNumbers} numbers, your winners is {money.ToString("C2")}", "Winner",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InformationOnWinning()
        {
            if (hitTheNumbers < 3)
            {
                MessageBox.Show("Sorry not this time. You haven't hit enough numbers.", "Winner", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (hitTheNumbers == 3)
            {
                MessagesOfWinnings(CalculationOfWinnings());
                VictoryStatistics();
            }
            else if (hitTheNumbers == 4)
            {
                MessagesOfWinnings(CalculationOfWinnings());
                VictoryStatistics();
            }
            else if (hitTheNumbers == 5)
            {
                MessagesOfWinnings(CalculationOfWinnings());
                VictoryStatistics();
            }
            else
            {
                MessageBox.Show($"Congratilation you hit the: {hitTheNumbers} numbers, you wan a jackpot {jackpot:C2}", "Winner",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                VictoryStatistics();
            }
        }
        private void VictoryStatistics()
        {
            if(hitTheNumbers >=3 && 5 >= hitTheNumbers)
            {
                totalCash += CalculationOfWinnings();
                total_cash.Text = totalCash.ToString("C2");
                totalWins += 1;
                total_wins_count.Text = totalWins.ToString();
            }
            if (hitTheNumbers == 6)
            {
                totalCash += jackpot;
                total_cash.Text = totalCash.ToString("C2");
                totalWins += 1;
                total_wins_count.Text = totalWins.ToString();
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
                GenerateRandomNambersForPlayes();
            }
        }
        private void RestartRandomNumbers()
        {
            jackpot_money.Text = GenerateJackpot();
            drawn_numbers_1.Text = 0.ToString();
            drawn_numbers_2.Text = 0.ToString();
            drawn_numbers_3.Text = 0.ToString();
            drawn_numbers_4.Text = 0.ToString();
            drawn_numbers_5.Text = 0.ToString();
            drawn_numbers_6.Text = 0.ToString();
            drawingNumbers.Clear();
            hitTheNumbers = 0;
            quit_game_button.Visible = false;
            again_button.Visible = false;
            start_game_button.Enabled = true;
        }
        private void RestartSelectedNumbers()
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
            jackpot_money.Text = GenerateJackpot();
        }
        private void again_button_Click(object sender, EventArgs e)
        {
            if (select.startGameSelectionNumbers)
            {
                if (MessageBox.Show("Do you want select new numbers", "New numbers", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               DialogResult.Yes)
                {
                    RestartSelectedNumbers();
                }
                else
                {
                    RestartRandomNumbers();
                }
            }
            else
            {
                if (MessageBox.Show("Do you want to draw new numbers", "New numbers", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               DialogResult.Yes)
                {
                    randomNumbersPlayer.Clear();
                    GenerateRandomNambersForPlayes();
                    RestartRandomNumbers();
                }
                else
                {
                    RestartRandomNumbers();
                }
            }
        }
        private void start_game_button_Click(object sender, EventArgs e)
        {
            if (totalCash < 3)
            {
                MessageBox.Show("Can't start new draw because you don't have cash", "Start Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("Do you want restart game?", "Restart Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 
                    DialogResult.Yes)
                {
                    totalCash = 50;
                    total_cash.Text = totalCash.ToString("C2");
                    totalDraws = 0;
                    total_draws.Text = totalDraws.ToString();
                    totalWins = 0;
                    total_wins_count.Text = totalWins.ToString();
                    if (select.startGameSelectionNumbers)
                    {
                        if (MessageBox.Show("Do you want selected new numbers", "Selected Numbers", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                        {
                            RestartSelectedNumbers();
                        }
                    }
                    else
                    {
                        GenerateRandomNambersForPlayes();
                        RestartRandomNumbers();
                    }
                }
                else
                {
                    Dispose();
                }
            }
            else
            {
                GenerationOfDrawingNumbers();
                totalDraws += 1;
                total_draws.Text = totalDraws.ToString();
                totalCash -= betCash;
                total_cash.Text = totalCash.ToString("C2");
                VeryficationOfTheNumbersHit();
                start_game_button.Enabled = false;
                again_button.Visible = true;
                quit_game_button.Visible = true;
            } 
        }
        private void quit_game_button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LottoDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (select.CloseWindowMessage() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //to-do
        //dodać zapisywanie oraz wczytywanie 
        //dodać total jackpot
    }
}
