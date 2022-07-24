using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    public partial class SelectionNumbers : Form
    {
        public SelectionNumbers()
        {
            InitializeComponent();
        }

        public List<int> numbersSelected = new List<int>();

        private int selectedNumberCount = 0;
        private int maximumNumberCount = 6;
        public bool startGameSelectionNumbers = false;
        public bool backToMenu = false;
        
        #region Messages Functions
        public DialogResult CloseWindowMessage()
        {
            return MessageBox.Show("Do you want close the window?", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult StartGameMessage()
        {
            return MessageBox.Show("Are you sure you want to start a game?", "Start Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult MessageErrorMaximumNumbersSelected()
        {
            return MessageBox.Show("You have selected the maximum number of digits", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        /// <summary>
        /// Function supporting clicked buttons with the addition of a number to the list.
        /// </summary>
        /// <param name="x">Button that was clicked</param>
        /// <param name="numberAddOrRemove">Number to be added or removed from the list.</param>
        private void ButtonsSelectionNumbers(Button x, int numberAddOrRemove)
        {
            if (x.BackColor == SystemColors.Control && selectedNumberCount < maximumNumberCount)
            {
                if (x.BackColor == SystemColors.Control)
                {
                    x.BackColor = Color.Green;
                    x.ForeColor = Color.White;
                    selectedNumberCount++;
                    number_count.Text = selectedNumberCount.ToString();
                    numbersSelected.Add(numberAddOrRemove);
                }
            }
            else if (!(x.BackColor == SystemColors.Control) && selectedNumberCount == maximumNumberCount ||
                selectedNumberCount < maximumNumberCount)
            {
                x.BackColor = SystemColors.Control;
                x.ForeColor = Color.DarkGray;
                selectedNumberCount--;
                number_count.Text = selectedNumberCount.ToString();
                numbersSelected.Remove(numberAddOrRemove);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }

        }
        private void back_button_Click(object sender, EventArgs e)
        {
            if (CloseWindowMessage() == DialogResult.Yes)
            {
                backToMenu = true;
                Dispose();
            }
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            if (number_count.Text == 6.ToString())
            {
                if (StartGameMessage() == DialogResult.Yes)
                {
                    startGameSelectionNumbers = true;
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show($"The game cannot be started because 6 numbers have not been selected.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void number_1_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_1, 1);
        }
        private void number_2_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_2, 2);
        }
        private void number_3_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_3, 3);
        }
        private void number_4_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_4, 4);
        }
        private void number_5_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_5, 5);
        }
        private void number_6_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_6, 6);
        }
        private void number_7_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_7, 7);
        }
        private void number_8_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_8, 8);
        }
        private void number_9_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_9, 9);
        }
        private void number_10_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_10, 10);
        }
        private void number_11_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_11, 11);

        }
        private void number_12_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_12, 12);

        }
        private void number_13_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_13, 13);

        }
        private void number_14_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_14, 14);

        }
        private void number_15_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_15, 15);

        }
        private void number_16_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_16, 16);

        }
        private void number_17_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_17, 17);

        }
        private void number_18_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_18, 18);

        }
        private void number_19_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_19, 19);

        }
        private void number_20_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_20, 20);

        }
        private void number_21_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_21, 21);

        }
        private void number_22_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_22, 22);

        }
        private void number_23_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_23, 23);

        }
        private void number_24_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_24, 24);

        }
        private void number_25_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_25, 25);

        }
        private void number_26_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_26, 26);

        }
        private void number_27_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_27, 27);

        }
        private void number_28_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_28, 28);

        }
        private void number_29_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_29, 29);

        }
        private void number_30_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_30, 30);

        }
        private void number_31_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_31, 31);

        }
        private void number_32_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_32, 32);

        }
        private void number_33_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_33, 33);

        }
        private void number_34_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_34, 34);

        }
        private void number_35_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_35, 35);

        }
        private void number_36_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_36, 36);

        }
        private void number_37_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_37, 37);

        }
        private void number_38_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_38, 38);

        }
        private void number_39_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_39, 39);

        }
        private void number_40_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_40, 40);

        }
        private void number_41_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_41, 41);

        }
        private void number_42_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_42, 42);

        }
        private void number_43_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_43, 43);

        }
        private void number_44_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_44, 44);

        }
        private void number_45_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_45, 45);

        }
        private void number_46_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_46, 46);

        }
        private void number_47_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_47, 47);

        }
        private void number_48_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_48, 48);

        }
        private void number_49_Click(object sender, EventArgs e)
        {
            ButtonsSelectionNumbers(number_49, 49);

        }
    }
}
