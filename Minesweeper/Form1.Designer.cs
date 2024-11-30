namespace Minesweeper
{
    partial class MainMenu
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
            mineNumText = new TextBox();
            EntryLabel = new Label();
            startButton = new Button();
            FlagButton = new Button();
            MineCountLabel = new Label();
            RemainigLabel = new Label();
            RestartButton = new Button();
            SuspendLayout();
            // 
            // mineNumText
            // 
            mineNumText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mineNumText.Location = new Point(550, 275);
            mineNumText.Name = "mineNumText";
            mineNumText.Size = new Size(150, 38);
            mineNumText.TabIndex = 1;
            mineNumText.TextAlign = HorizontalAlignment.Center;
            // 
            // EntryLabel
            // 
            EntryLabel.AutoSize = true;
            EntryLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            EntryLabel.Location = new Point(440, 204);
            EntryLabel.Name = "EntryLabel";
            EntryLabel.Size = new Size(370, 38);
            EntryLabel.TabIndex = 2;
            EntryLabel.Text = "Enter the number of mines";
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            startButton.Location = new Point(575, 350);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 40);
            startButton.TabIndex = 0;
            startButton.Text = "Start!";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_click;
            // 
            // FlagButton
            // 
            FlagButton.BackColor = Color.White;
            FlagButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FlagButton.Location = new Point(1143, 167);
            FlagButton.Name = "FlagButton";
            FlagButton.Size = new Size(90, 60);
            FlagButton.TabIndex = 3;
            FlagButton.Text = "Flag";
            FlagButton.UseVisualStyleBackColor = false;
            FlagButton.Visible = false;
            FlagButton.Click += FlagButton_Click;
            // 
            // MineCountLabel
            // 
            MineCountLabel.AutoSize = true;
            MineCountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MineCountLabel.Location = new Point(994, 52);
            MineCountLabel.Name = "MineCountLabel";
            MineCountLabel.Size = new Size(130, 28);
            MineCountLabel.TabIndex = 4;
            MineCountLabel.Text = "Mine Count: ";
            MineCountLabel.Visible = false;
            // 
            // RemainigLabel
            // 
            RemainigLabel.AutoSize = true;
            RemainigLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            RemainigLabel.Location = new Point(994, 106);
            RemainigLabel.Name = "RemainigLabel";
            RemainigLabel.Size = new Size(119, 28);
            RemainigLabel.TabIndex = 5;
            RemainigLabel.Text = "Remaining: ";
            RemainigLabel.Visible = false;
            // 
            // RestartButton
            // 
            RestartButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            RestartButton.Location = new Point(1143, 625);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(90, 50);
            RestartButton.TabIndex = 6;
            RestartButton.Text = "Restart";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Visible = false;
            RestartButton.Click += RestartButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1258, 849);
            Controls.Add(RestartButton);
            Controls.Add(RemainigLabel);
            Controls.Add(MineCountLabel);
            Controls.Add(FlagButton);
            Controls.Add(startButton);
            Controls.Add(EntryLabel);
            Controls.Add(mineNumText);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minesweeper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mineNumText;
        private Label EntryLabel;
        private Button startButton;
        private Button FlagButton;
        private Label MineCountLabel;
        private Label RemainigLabel;
        private Button RestartButton;
    }
}
