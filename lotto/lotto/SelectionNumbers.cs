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

        protected DialogResult CloseControl()
        {
            return MessageBox.Show("Do you want close the window?", "Close Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private DialogResult MessageErrorMaximumNumbersSelected()
        {
            return MessageBox.Show("You have selected the maximum number of digits", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (CloseControl() == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            
        }
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

        }

        private void number_16_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_16_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 17
        private void number_17_Click(object sender, EventArgs e)
        {

        }

        private void number_17_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_17_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 18
        private void number_18_Click(object sender, EventArgs e)
        {

        }

        private void number_18_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_18_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 19
        private void number_19_Click(object sender, EventArgs e)
        {

        }

        private void number_19_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_19_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 20
        private void number_20_Click(object sender, EventArgs e)
        {

        }

        private void number_20_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_20_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 21
        private void number_21_Click(object sender, EventArgs e)
        {

        }

        private void number_21_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_21_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 22
        private void number_22_Click(object sender, EventArgs e)
        {

        }

        private void number_22_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_22_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 23
        private void number_23_Click(object sender, EventArgs e)
        {

        }

        private void number_23_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_23_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 24
        private void number_24_Click(object sender, EventArgs e)
        {

        }

        private void number_24_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_24_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 25
        private void number_25_Click(object sender, EventArgs e)
        {

        }

        private void number_25_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_25_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 26
        private void number_26_Click(object sender, EventArgs e)
        {

        }

        private void number_26_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_26_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 27
        private void number_27_Click(object sender, EventArgs e)
        {

        }

        private void number_27_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_27_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 28
        private void number_28_Click(object sender, EventArgs e)
        {

        }

        private void number_28_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_28_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 29
        private void number_29_Click(object sender, EventArgs e)
        {

        }

        private void number_29_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_29_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 30
        private void number_30_Click(object sender, EventArgs e)
        {

        }

        private void number_30_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_30_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 31
        private void number_31_Click(object sender, EventArgs e)
        {

        }

        private void number_31_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_31_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 32
        private void number_32_Click(object sender, EventArgs e)
        {

        }

        private void number_32_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_32_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 33
        private void number_33_Click(object sender, EventArgs e)
        {

        }

        private void number_33_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_33_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 34
        private void number_34_Click(object sender, EventArgs e)
        {

        }

        private void number_34_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_34_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 35
        private void number_35_Click(object sender, EventArgs e)
        {

        }

        private void number_35_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_35_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 36
        private void number_36_Click(object sender, EventArgs e)
        {

        }

        private void number_36_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_36_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 37
        private void number_37_Click(object sender, EventArgs e)
        {

        }

        private void number_37_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_37_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 38
        private void number_38_Click(object sender, EventArgs e)
        {

        }

        private void number_38_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_38_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 39
        private void number_39_Click(object sender, EventArgs e)
        {

        }

        private void number_39_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_39_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 40
        private void number_40_Click(object sender, EventArgs e)
        {

        }

        private void number_40_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_40_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 41
        private void number_41_Click(object sender, EventArgs e)
        {

        }

        private void number_41_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_41_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 42
        private void number_42_Click(object sender, EventArgs e)
        {

        }

        private void number_42_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_42_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 43
        private void number_43_Click(object sender, EventArgs e)
        {

        }

        private void number_43_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_43_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 44
        private void number_44_Click(object sender, EventArgs e)
        {

        }

        private void number_44_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_44_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 45
        private void number_45_Click(object sender, EventArgs e)
        {

        }

        private void number_45_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_45_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 46
        private void number_46_Click(object sender, EventArgs e)
        {

        }

        private void number_46_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_46_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 47
        private void number_47_Click(object sender, EventArgs e)
        {

        }

        private void number_47_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_47_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 48
        private void number_48_Click(object sender, EventArgs e)
        {

        }

        private void number_48_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_48_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
        #region number 49
        private void number_49_Click(object sender, EventArgs e)
        {

        }

        private void number_49_MouseEnter(object sender, EventArgs e)
        {

        }

        private void number_49_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
