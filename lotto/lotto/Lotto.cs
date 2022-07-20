namespace lotto
{
    public partial class Lotto : Form
    {
        public bool startLottoSimulatorRandomGame = false;
        public bool startLottoSimulatorSelectGame = false;
        protected LottoDashboard dashboard;
        public Lotto()
        {
            InitializeComponent();
        }

        private void select_button_menu_Click(object sender, EventArgs e)
        {
            if (StartGameMessage() == DialogResult.Yes)
            {
                startLottoSimulatorSelectGame = true;
            }
        }

        private void select_button_menu_MouseEnter(object sender, EventArgs e)
        {
            select_button_menu.ForeColor = Color.White;
            select_button_menu.BackColor = Color.CadetBlue;
        }

        private void select_button_menu_MouseLeave(object sender, EventArgs e)
        {
            select_button_menu.ForeColor = Color.DarkGray;
            select_button_menu.BackColor = SystemColors.Control;
        }

        private void random_button_menu_Click(object sender, EventArgs e)
        {
            if (StartGameMessage() == DialogResult.Yes)
            {
                startLottoSimulatorRandomGame = true;
                this.Visible = false;
                dashboard = new LottoDashboard();
                dashboard.Show();
            }
        }
        private void random_button_menu_MouseEnter(object sender, EventArgs e)
        {
            random_button_menu.ForeColor = Color.White;
            random_button_menu.BackColor = Color.CadetBlue;
        }

        private void random_button_menu_MouseLeave(object sender, EventArgs e)
        {
            random_button_menu.ForeColor = Color.DarkGray;
            random_button_menu.BackColor = SystemColors.Control;
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
            if (CloseGameMessage() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public DialogResult CloseGameMessage()
        {
            return MessageBox.Show("Do you want quit the game?", "Exit game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        protected DialogResult StartGameMessage()
        {
            return MessageBox.Show("Do you want start game?", "Start Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}