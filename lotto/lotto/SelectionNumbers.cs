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
        private int countNumber = 0;
        private int maximumNumberCount = 6;
        protected List<int> numbersSelected = new List<int>();
        public SelectionNumbers()
        {
            InitializeComponent();
        }
        #region Messages
        public DialogResult CloseWindowMessage()
        {
            return MessageBox.Show("Do you want close the window?", "Close Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        #region Start and Stop button
        private void back_button_Click(object sender, EventArgs e)
        {
            if (CloseWindowMessage() == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (number_count.Text == 6.ToString())
            {
                if (StartGameMessage() == DialogResult.Yes)
                {
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show($"The game cannot be started because 6 numbers have not been selected. You selected {number_count.Text} numbers.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region number 1
        private void number_1_Click(object sender, EventArgs e)
        {
            if (number_1.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_1.BackColor == SystemColors.Control)
                {
                    number_1.BackColor = Color.Green;
                    number_1.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(1);
                }
            }
            else if (!(number_1.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_1.BackColor = SystemColors.Control;
                number_1.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(1);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 2
        private void number_2_Click(object sender, EventArgs e)
        {
            if (number_2.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_2.BackColor == SystemColors.Control)
                {
                    number_2.BackColor = Color.Green;
                    number_2.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(2);
                }
            }
            else if (!(number_2.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_2.BackColor = SystemColors.Control;
                number_2.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(2);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 3
        private void number_3_Click(object sender, EventArgs e)
        {
            if (number_3.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_3.BackColor == SystemColors.Control)
                {
                    number_3.BackColor = Color.Green;
                    number_3.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(3);
                }
            }
            else if (!(number_3.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_3.BackColor = SystemColors.Control;
                number_3.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(3);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 4
        private void number_4_Click(object sender, EventArgs e)
        {
            if (number_4.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_4.BackColor == SystemColors.Control)
                {
                    number_4.BackColor = Color.Green;
                    number_4.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(4);
                }
            }
            else if (!(number_4.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_4.BackColor = SystemColors.Control;
                number_4.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(4);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 5
        private void number_5_Click(object sender, EventArgs e)
        {
            if (number_5.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_5.BackColor == SystemColors.Control)
                {
                    number_5.BackColor = Color.Green;
                    number_5.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(5);
                }
            }
            else if (!(number_5.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_5.BackColor = SystemColors.Control;
                number_5.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(5);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 6
        private void number_6_Click(object sender, EventArgs e)
        {
            if (number_6.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_6.BackColor == SystemColors.Control)
                {
                    number_6.BackColor = Color.Green;
                    number_6.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(6);
                }
            }
            else if (!(number_6.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_6.BackColor = SystemColors.Control;
                number_6.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(6);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 7
        private void number_7_Click(object sender, EventArgs e)
        {
            if (number_7.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_7.BackColor == SystemColors.Control)
                {
                    number_7.BackColor = Color.Green;
                    number_7.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(7);
                }
            }
            else if (!(number_7.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_7.BackColor = SystemColors.Control;
                number_7.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(7);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 8
        private void number_8_Click(object sender, EventArgs e)
        {
            if (number_8.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_8.BackColor == SystemColors.Control)
                {
                    number_8.BackColor = Color.Green;
                    number_8.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(8);
                }
            }
            else if (!(number_8.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_8.BackColor = SystemColors.Control;
                number_8.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(8);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 9
        private void number_9_Click(object sender, EventArgs e)
        {
            if (number_9.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_9.BackColor == SystemColors.Control)
                {
                    number_9.BackColor = Color.Green;
                    number_9.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(9);
                }
            }
            else if (!(number_9.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_9.BackColor = SystemColors.Control;
                number_9.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(9);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 10
        private void number_10_Click(object sender, EventArgs e)
        {
            if (number_10.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_10.BackColor == SystemColors.Control)
                {
                    number_10.BackColor = Color.Green;
                    number_10.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(10);
                }
            }
            else if (!(number_10.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_10.BackColor = SystemColors.Control;
                number_10.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(10);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 11
        private void number_11_Click(object sender, EventArgs e)
        {
            if (number_11.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_11.BackColor == SystemColors.Control)
                {
                    number_11.BackColor = Color.Green;
                    number_11.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(11);
                }
            }
            else if (!(number_11.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_11.BackColor = SystemColors.Control;
                number_11.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(11);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 12
        private void number_12_Click(object sender, EventArgs e)
        {
            if (number_12.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_12.BackColor == SystemColors.Control)
                {
                    number_12.BackColor = Color.Green;
                    number_12.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(12);
                }
            }
            else if (!(number_12.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_12.BackColor = SystemColors.Control;
                number_12.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(12);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 13
        private void number_13_Click(object sender, EventArgs e)
        {
            if (number_13.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_13.BackColor == SystemColors.Control)
                {
                    number_13.BackColor = Color.Green;
                    number_13.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(13);
                }
            }
            else if (!(number_13.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_13.BackColor = SystemColors.Control;
                number_13.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(13);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 14
        private void number_14_Click(object sender, EventArgs e)
        {
            if (number_14.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_14.BackColor == SystemColors.Control)
                {
                    number_14.BackColor = Color.Green;
                    number_14.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(14);
                }
            }
            else if (!(number_14.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_14.BackColor = SystemColors.Control;
                number_14.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(14);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 15
        private void number_15_Click(object sender, EventArgs e)
        {
            if (number_15.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_15.BackColor == SystemColors.Control)
                {
                    number_15.BackColor = Color.Green;
                    number_15.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(15);
                }
            }
            else if (!(number_15.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_15.BackColor = SystemColors.Control;
                number_15.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(15);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 16
        private void number_16_Click(object sender, EventArgs e)
        {
            if (number_16.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_16.BackColor == SystemColors.Control)
                {
                    number_16.BackColor = Color.Green;
                    number_16.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(16);
                }
            }
            else if (!(number_16.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_16.BackColor = SystemColors.Control;
                number_16.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(16);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 17
        private void number_17_Click(object sender, EventArgs e)
        {
            if (number_17.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_17.BackColor == SystemColors.Control)
                {
                    number_17.BackColor = Color.Green;
                    number_17.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(17);
                }
            }
            else if (!(number_17.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_17.BackColor = SystemColors.Control;
                number_17.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(17);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 18
        private void number_18_Click(object sender, EventArgs e)
        {
            if (number_18.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_18.BackColor == SystemColors.Control)
                {
                    number_18.BackColor = Color.Green;
                    number_18.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(18);
                }
            }
            else if (!(number_18.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_18.BackColor = SystemColors.Control;
                number_18.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(18);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 19
        private void number_19_Click(object sender, EventArgs e)
        {
            if (number_19.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_19.BackColor == SystemColors.Control)
                {
                    number_19.BackColor = Color.Green;
                    number_19.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(19);
                }
            }
            else if (!(number_19.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_19.BackColor = SystemColors.Control;
                number_19.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(19);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 20
        private void number_20_Click(object sender, EventArgs e)
        {
            if (number_20.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_20.BackColor == SystemColors.Control)
                {
                    number_20.BackColor = Color.Green;
                    number_20.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(20);
                }
            }
            else if (!(number_20.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_20.BackColor = SystemColors.Control;
                number_20.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(20);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 21
        private void number_21_Click(object sender, EventArgs e)
        {
            if (number_21.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_21.BackColor == SystemColors.Control)
                {
                    number_21.BackColor = Color.Green;
                    number_21.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(21);
                }
            }
            else if (!(number_21.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_21.BackColor = SystemColors.Control;
                number_21.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(21);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 22
        private void number_22_Click(object sender, EventArgs e)
        {
            if (number_22.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_22.BackColor == SystemColors.Control)
                {
                    number_22.BackColor = Color.Green;
                    number_22.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(22);
                }
            }
            else if (!(number_22.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_22.BackColor = SystemColors.Control;
                number_22.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(22);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 23
        private void number_23_Click(object sender, EventArgs e)
        {
            if (number_23.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_23.BackColor == SystemColors.Control)
                {
                    number_23.BackColor = Color.Green;
                    number_23.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(23);
                }
            }
            else if (!(number_23.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_23.BackColor = SystemColors.Control;
                number_23.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(23);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 24
        private void number_24_Click(object sender, EventArgs e)
        {
            if (number_24.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_24.BackColor == SystemColors.Control)
                {
                    number_24.BackColor = Color.Green;
                    number_24.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(24);
                }
            }
            else if (!(number_24.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_24.BackColor = SystemColors.Control;
                number_24.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(24);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 25
        private void number_25_Click(object sender, EventArgs e)
        {
            if (number_25.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_25.BackColor == SystemColors.Control)
                {
                    number_25.BackColor = Color.Green;
                    number_25.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(25);
                }
            }
            else if (!(number_25.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_25.BackColor = SystemColors.Control;
                number_25.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(25);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 26
        private void number_26_Click(object sender, EventArgs e)
        {
            if (number_26.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_26.BackColor == SystemColors.Control)
                {
                    number_26.BackColor = Color.Green;
                    number_26.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(26);
                }
            }
            else if (!(number_26.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_26.BackColor = SystemColors.Control;
                number_26.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(26);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 27
        private void number_27_Click(object sender, EventArgs e)
        {
            if (number_27.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_27.BackColor == SystemColors.Control)
                {
                    number_27.BackColor = Color.Green;
                    number_27.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(27);
                }
            }
            else if (!(number_27.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_27.BackColor = SystemColors.Control;
                number_27.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(27);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 28
        private void number_28_Click(object sender, EventArgs e)
        {
            if (number_28.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_28.BackColor == SystemColors.Control)
                {
                    number_28.BackColor = Color.Green;
                    number_28.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(28);
                }
            }
            else if (!(number_28.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_28.BackColor = SystemColors.Control;
                number_28.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(28);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 29
        private void number_29_Click(object sender, EventArgs e)
        {
            if (number_29.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_29.BackColor == SystemColors.Control)
                {
                    number_29.BackColor = Color.Green;
                    number_29.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(29);
                }
            }
            else if (!(number_29.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_29.BackColor = SystemColors.Control;
                number_29.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(29);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 30
        private void number_30_Click(object sender, EventArgs e)
        {
            if (number_30.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_30.BackColor == SystemColors.Control)
                {
                    number_30.BackColor = Color.Green;
                    number_30.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(30);
                }
            }
            else if (!(number_30.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_30.BackColor = SystemColors.Control;
                number_30.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(30);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 31
        private void number_31_Click(object sender, EventArgs e)
        {
            if (number_31.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_31.BackColor == SystemColors.Control)
                {
                    number_31.BackColor = Color.Green;
                    number_31.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(31);
                }
            }
            else if (!(number_31.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_31.BackColor = SystemColors.Control;
                number_31.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(31);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 32
        private void number_32_Click(object sender, EventArgs e)
        {
            if (number_32.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_32.BackColor == SystemColors.Control)
                {
                    number_32.BackColor = Color.Green;
                    number_32.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(32);
                }
            }
            else if (!(number_32.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_32.BackColor = SystemColors.Control;
                number_32.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(32);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 33
        private void number_33_Click(object sender, EventArgs e)
        {
            if (number_33.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_33.BackColor == SystemColors.Control)
                {
                    number_33.BackColor = Color.Green;
                    number_33.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(33);
                }
            }
            else if (!(number_33.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_33.BackColor = SystemColors.Control;
                number_33.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(33);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 34
        private void number_34_Click(object sender, EventArgs e)
        {
            if (number_34.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_34.BackColor == SystemColors.Control)
                {
                    number_34.BackColor = Color.Green;
                    number_34.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(34);
                }
            }
            else if (!(number_34.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_34.BackColor = SystemColors.Control;
                number_34.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(34);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 35
        private void number_35_Click(object sender, EventArgs e)
        {
            if (number_35.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_35.BackColor == SystemColors.Control)
                {
                    number_35.BackColor = Color.Green;
                    number_35.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(35);
                }
            }
            else if (!(number_35.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_35.BackColor = SystemColors.Control;
                number_35.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(35);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 36
        private void number_36_Click(object sender, EventArgs e)
        {
            if (number_36.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_36.BackColor == SystemColors.Control)
                {
                    number_36.BackColor = Color.Green;
                    number_36.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(36);
                }
            }
            else if (!(number_36.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_36.BackColor = SystemColors.Control;
                number_36.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(36);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 37
        private void number_37_Click(object sender, EventArgs e)
        {
            if (number_37.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_37.BackColor == SystemColors.Control)
                {
                    number_37.BackColor = Color.Green;
                    number_37.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(37);
                }
            }
            else if (!(number_37.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_37.BackColor = SystemColors.Control;
                number_37.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(37);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 38
        private void number_38_Click(object sender, EventArgs e)
        {
            if (number_38.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_38.BackColor == SystemColors.Control)
                {
                    number_38.BackColor = Color.Green;
                    number_38.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(38);
                }
            }
            else if (!(number_38.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_38.BackColor = SystemColors.Control;
                number_38.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(38);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 39
        private void number_39_Click(object sender, EventArgs e)
        {
            if (number_39.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_39.BackColor == SystemColors.Control)
                {
                    number_39.BackColor = Color.Green;
                    number_39.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(39);
                }
            }
            else if (!(number_39.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_39.BackColor = SystemColors.Control;
                number_39.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(39);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 40
        private void number_40_Click(object sender, EventArgs e)
        {
            if (number_40.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_40.BackColor == SystemColors.Control)
                {
                    number_40.BackColor = Color.Green;
                    number_40.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(40);
                }
            }
            else if (!(number_40.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_40.BackColor = SystemColors.Control;
                number_40.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(40);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 41
        private void number_41_Click(object sender, EventArgs e)
        {
            if (number_41.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_41.BackColor == SystemColors.Control)
                {
                    number_41.BackColor = Color.Green;
                    number_41.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(41);
                }
            }
            else if (!(number_41.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_41.BackColor = SystemColors.Control;
                number_41.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(41);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 42
        private void number_42_Click(object sender, EventArgs e)
        {
            if (number_42.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_42.BackColor == SystemColors.Control)
                {
                    number_42.BackColor = Color.Green;
                    number_42.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(42);
                }
            }
            else if (!(number_42.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_42.BackColor = SystemColors.Control;
                number_42.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(42);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 43
        private void number_43_Click(object sender, EventArgs e)
        {
            if (number_43.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_43.BackColor == SystemColors.Control)
                {
                    number_43.BackColor = Color.Green;
                    number_43.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(43);
                }
            }
            else if (!(number_43.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_43.BackColor = SystemColors.Control;
                number_43.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(43);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 44
        private void number_44_Click(object sender, EventArgs e)
        {
            if (number_44.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_44.BackColor == SystemColors.Control)
                {
                    number_44.BackColor = Color.Green;
                    number_44.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(44);
                }
            }
            else if (!(number_44.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_44.BackColor = SystemColors.Control;
                number_44.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(44);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 45
        private void number_45_Click(object sender, EventArgs e)
        {
            if (number_45.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_45.BackColor == SystemColors.Control)
                {
                    number_45.BackColor = Color.Green;
                    number_45.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(45);
                }
            }
            else if (!(number_45.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_45.BackColor = SystemColors.Control;
                number_45.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(45);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 46
        private void number_46_Click(object sender, EventArgs e)
        {
            if (number_46.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_46.BackColor == SystemColors.Control)
                {
                    number_46.BackColor = Color.Green;
                    number_46.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(46);
                }
            }
            else if (!(number_46.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_46.BackColor = SystemColors.Control;
                number_46.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(46);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 47
        private void number_47_Click(object sender, EventArgs e)
        {
            if (number_47.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_47.BackColor == SystemColors.Control)
                {
                    number_47.BackColor = Color.Green;
                    number_47.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(47);
                }
            }
            else if (!(number_47.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_47.BackColor = SystemColors.Control;
                number_47.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(47);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 48
        private void number_48_Click(object sender, EventArgs e)
        {
            if (number_48.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_48.BackColor == SystemColors.Control)
                {
                    number_48.BackColor = Color.Green;
                    number_48.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(48);
                }
            }
            else if (!(number_48.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_48.BackColor = SystemColors.Control;
                number_48.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(48);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
        #region number 49
        private void number_49_Click(object sender, EventArgs e)
        {
            if (number_49.BackColor == SystemColors.Control && countNumber < maximumNumberCount)
            {
                if (number_49.BackColor == SystemColors.Control)
                {
                    number_49.BackColor = Color.Green;
                    number_49.ForeColor = Color.White;
                    countNumber++;
                    number_count.Text = countNumber.ToString();
                    numbersSelected.Add(49);
                }
            }
            else if (!(number_49.BackColor == SystemColors.Control) && countNumber == maximumNumberCount ||
                countNumber < maximumNumberCount)
            {
                number_49.BackColor = SystemColors.Control;
                number_49.ForeColor = Color.DarkGray;
                countNumber--;
                number_count.Text = countNumber.ToString();
                numbersSelected.Remove(49);
            }
            else
            {
                MessageErrorMaximumNumbersSelected();
            }
        }
        #endregion
    }
}
