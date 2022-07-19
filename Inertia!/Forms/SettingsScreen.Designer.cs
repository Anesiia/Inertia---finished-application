namespace Inertia_
{
    partial class SettingsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.DifficultyButton = new System.Windows.Forms.Button();
            this.MusicOnRadioButton = new System.Windows.Forms.RadioButton();
            this.MusicOffRadioButton = new System.Windows.Forms.RadioButton();
            this.MenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // InstructionButton
            // 
            this.InstructionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionButton.Location = new System.Drawing.Point(263, 94);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(210, 47);
            this.InstructionButton.TabIndex = 1;
            this.InstructionButton.Text = "How to play";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.OpenInstruction);
            // 
            // DifficultyButton
            // 
            this.DifficultyButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DifficultyButton.Location = new System.Drawing.Point(263, 147);
            this.DifficultyButton.Name = "DifficultyButton";
            this.DifficultyButton.Size = new System.Drawing.Size(210, 54);
            this.DifficultyButton.TabIndex = 2;
            this.DifficultyButton.Text = "Difficulty";
            this.DifficultyButton.UseVisualStyleBackColor = true;
            this.DifficultyButton.Click += new System.EventHandler(this.ChooseDifficulty);
            // 
            // MusicOnRadioButton
            // 
            this.MusicOnRadioButton.AutoSize = true;
            this.MusicOnRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.MusicOnRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MusicOnRadioButton.ForeColor = System.Drawing.Color.White;
            this.MusicOnRadioButton.Location = new System.Drawing.Point(308, 207);
            this.MusicOnRadioButton.Name = "MusicOnRadioButton";
            this.MusicOnRadioButton.Size = new System.Drawing.Size(122, 27);
            this.MusicOnRadioButton.TabIndex = 3;
            this.MusicOnRadioButton.TabStop = true;
            this.MusicOnRadioButton.Text = "Music ON";
            this.MusicOnRadioButton.UseVisualStyleBackColor = false;
            this.MusicOnRadioButton.CheckedChanged += new System.EventHandler(this.MusicOnRadioButton_CheckedChanged);
            // 
            // MusicOffRadioButton
            // 
            this.MusicOffRadioButton.AutoSize = true;
            this.MusicOffRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.MusicOffRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MusicOffRadioButton.ForeColor = System.Drawing.Color.White;
            this.MusicOffRadioButton.Location = new System.Drawing.Point(308, 240);
            this.MusicOffRadioButton.Name = "MusicOffRadioButton";
            this.MusicOffRadioButton.Size = new System.Drawing.Size(127, 27);
            this.MusicOffRadioButton.TabIndex = 4;
            this.MusicOffRadioButton.TabStop = true;
            this.MusicOffRadioButton.Text = "Music OFF";
            this.MusicOffRadioButton.UseVisualStyleBackColor = false;
            this.MusicOffRadioButton.CheckedChanged += new System.EventHandler(this.MusicOffRadioButton_CheckedChanged);
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuButton.Location = new System.Drawing.Point(263, 320);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(210, 65);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.Text = "To main menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inertia_.Resource1.depression;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.MusicOffRadioButton);
            this.Controls.Add(this.MusicOnRadioButton);
            this.Controls.Add(this.DifficultyButton);
            this.Controls.Add(this.InstructionButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button InstructionButton;
        private Button DifficultyButton;
        private RadioButton MusicOnRadioButton;
        private RadioButton MusicOffRadioButton;
        private Button MenuButton;
    }
}