namespace lotto
{
    public partial class Lotto : Form
    {
        public Lotto()
        {
            InitializeComponent();
        }

        private void select_button_menu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void select_button_menu_MouseEnter(object sender, EventArgs e)
        {
            //to-do
        }

        private void select_button_menu_MouseLeave(object sender, EventArgs e)
        {
            //to-do
        }
        private void random_button_menu_MouseEnter(object sender, EventArgs e)
        {
            //to-do
        }

        private void random_button_menu_MouseLeave(object sender, EventArgs e)
        {
            //to-do
        }

        private void random_button_menu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void exit_button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_button_menu_MouseEnter(object sender, EventArgs e)
        {
            exit_button_menu.ForeColor = Color.White;
            exit_button_menu.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void exit_button_menu_MouseLeave(object sender, EventArgs e)
        {
            exit_button_menu.ForeColor = Color.DarkGray;
            exit_button_menu.BackColor = SystemColors.Control;
        }

        private void Lotto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want quit the game?", "Exit game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}