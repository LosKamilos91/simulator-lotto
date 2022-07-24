namespace lotto
{
    public partial class Lotto : Form
    {
        public Lotto()
        {
            InitializeComponent();
        }

        public LottoDashboard dashboardPanel = new LottoDashboard();

        public bool openWindowWhenClickSelectInMenu = false;
        public bool openWindowWhenClickRandomInMenu = false;

        private DialogResult StartGameMessage()
        {
            return MessageBox.Show("Do you want start the game?", "Start Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #region Select Button
        private void select_button_menu_Click(object sender, EventArgs e)
        {
            if (StartGameMessage() == DialogResult.Yes)
            {
                openWindowWhenClickSelectInMenu = true;
                this.Dispose();
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
        #endregion

        #region Random Button
        private void random_button_menu_Click(object sender, EventArgs e)
        {
            if (StartGameMessage() == DialogResult.Yes)
            {
                openWindowWhenClickRandomInMenu = true;
                this.Dispose();
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
        #endregion

        #region Exit Button
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
        #endregion

        private void Lotto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want quit the game?", "Exit game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}