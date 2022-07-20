namespace lotto
{
    partial class Lotto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotto));
            this.img_lotto = new System.Windows.Forms.PictureBox();
            this.select_button_menu = new System.Windows.Forms.Button();
            this.exit_button_menu = new System.Windows.Forms.Button();
            this.random_button_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_lotto)).BeginInit();
            this.SuspendLayout();
            // 
            // img_lotto
            // 
            this.img_lotto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_lotto.BackgroundImage")));
            this.img_lotto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_lotto.InitialImage = null;
            this.img_lotto.Location = new System.Drawing.Point(12, 12);
            this.img_lotto.Name = "img_lotto";
            this.img_lotto.Size = new System.Drawing.Size(360, 184);
            this.img_lotto.TabIndex = 5;
            this.img_lotto.TabStop = false;
            // 
            // select_button_menu
            // 
            this.select_button_menu.BackColor = System.Drawing.SystemColors.Control;
            this.select_button_menu.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.select_button_menu.FlatAppearance.BorderSize = 0;
            this.select_button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_button_menu.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.select_button_menu.ForeColor = System.Drawing.Color.DarkGray;
            this.select_button_menu.Location = new System.Drawing.Point(12, 239);
            this.select_button_menu.Name = "select_button_menu";
            this.select_button_menu.Size = new System.Drawing.Size(174, 53);
            this.select_button_menu.TabIndex = 11;
            this.select_button_menu.Text = "SELECT";
            this.select_button_menu.UseVisualStyleBackColor = false;
            // 
            // exit_button_menu
            // 
            this.exit_button_menu.BackColor = System.Drawing.SystemColors.Control;
            this.exit_button_menu.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.exit_button_menu.FlatAppearance.BorderSize = 0;
            this.exit_button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button_menu.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_button_menu.ForeColor = System.Drawing.Color.DarkGray;
            this.exit_button_menu.Location = new System.Drawing.Point(12, 298);
            this.exit_button_menu.Name = "exit_button_menu";
            this.exit_button_menu.Size = new System.Drawing.Size(360, 62);
            this.exit_button_menu.TabIndex = 10;
            this.exit_button_menu.Text = "EXIT";
            this.exit_button_menu.UseVisualStyleBackColor = false;
            // 
            // random_button_menu
            // 
            this.random_button_menu.BackColor = System.Drawing.SystemColors.Control;
            this.random_button_menu.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.random_button_menu.FlatAppearance.BorderSize = 0;
            this.random_button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_button_menu.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.random_button_menu.ForeColor = System.Drawing.Color.DarkGray;
            this.random_button_menu.Location = new System.Drawing.Point(198, 239);
            this.random_button_menu.Name = "random_button_menu";
            this.random_button_menu.Size = new System.Drawing.Size(174, 53);
            this.random_button_menu.TabIndex = 9;
            this.random_button_menu.Text = "RANDOM";
            this.random_button_menu.UseVisualStyleBackColor = false;
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 382);
            this.Controls.Add(this.select_button_menu);
            this.Controls.Add(this.exit_button_menu);
            this.Controls.Add(this.random_button_menu);
            this.Controls.Add(this.img_lotto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 421);
            this.MinimumSize = new System.Drawing.Size(400, 421);
            this.Name = "Lotto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto simulator";
            ((System.ComponentModel.ISupportInitialize)(this.img_lotto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox img_lotto;
        private Button select_button_menu;
        private Button exit_button_menu;
        private Button random_button_menu;
    }
}