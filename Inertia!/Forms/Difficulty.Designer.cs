namespace Inertia_
{
    partial class Difficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Difficulty));
            this.label1 = new System.Windows.Forms.Label();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.ImpossibleRadioButton = new System.Windows.Forms.RadioButton();
            this.SuicideRadioButton = new System.Windows.Forms.RadioButton();
            this.MenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please, choose a level of difficultly";
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.EasyRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EasyRadioButton.Location = new System.Drawing.Point(86, 92);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(75, 27);
            this.EasyRadioButton.TabIndex = 1;
            this.EasyRadioButton.TabStop = true;
            this.EasyRadioButton.Tag = levelOfDifficulty.Easy;
            this.EasyRadioButton.Text = "Easy";
            this.EasyRadioButton.UseVisualStyleBackColor = false;
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.NormalRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NormalRadioButton.Location = new System.Drawing.Point(86, 125);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(103, 27);
            this.NormalRadioButton.TabIndex = 2;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Tag = levelOfDifficulty.Normal;
            this.NormalRadioButton.Text = "Normal";
            this.NormalRadioButton.UseVisualStyleBackColor = false;
            // 
            // HardRadioButton
            // 
            this.HardRadioButton.AutoSize = true;
            this.HardRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.HardRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HardRadioButton.Location = new System.Drawing.Point(86, 158);
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.Size = new System.Drawing.Size(79, 27);
            this.HardRadioButton.TabIndex = 3;
            this.HardRadioButton.TabStop = true;
            this.HardRadioButton.Tag = levelOfDifficulty.Hard;
            this.HardRadioButton.Text = "Hard";
            this.HardRadioButton.UseVisualStyleBackColor = false;
            // 
            // ImpossibleRadioButton
            // 
            this.ImpossibleRadioButton.AutoSize = true;
            this.ImpossibleRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ImpossibleRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImpossibleRadioButton.Location = new System.Drawing.Point(86, 191);
            this.ImpossibleRadioButton.Name = "ImpossibleRadioButton";
            this.ImpossibleRadioButton.Size = new System.Drawing.Size(133, 27);
            this.ImpossibleRadioButton.TabIndex = 4;
            this.ImpossibleRadioButton.TabStop = true;
            this.ImpossibleRadioButton.Tag = levelOfDifficulty.Impossible;
            this.ImpossibleRadioButton.Text = "Impossible";
            this.ImpossibleRadioButton.UseVisualStyleBackColor = false;
            // 
            // SuicideRadioButton
            // 
            this.SuicideRadioButton.AutoSize = true;
            this.SuicideRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SuicideRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SuicideRadioButton.Location = new System.Drawing.Point(86, 224);
            this.SuicideRadioButton.Name = "SuicideRadioButton";
            this.SuicideRadioButton.Size = new System.Drawing.Size(99, 27);
            this.SuicideRadioButton.TabIndex = 5;
            this.SuicideRadioButton.TabStop = true;
            this.SuicideRadioButton.Tag = levelOfDifficulty.Suicide;
            this.SuicideRadioButton.Text = "Suicide";
            this.SuicideRadioButton.UseVisualStyleBackColor = false;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Linen;
            this.MenuButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuButton.Location = new System.Drawing.Point(59, 318);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(271, 45);
            this.MenuButton.TabIndex = 6;
            this.MenuButton.Text = "To the main menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::Inertia_.Resource1.angry11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 503);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.SuicideRadioButton);
            this.Controls.Add(this.ImpossibleRadioButton);
            this.Controls.Add(this.HardRadioButton);
            this.Controls.Add(this.NormalRadioButton);
            this.Controls.Add(this.EasyRadioButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficulty";
            this.Load += new System.EventHandler(this.Difficulty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton EasyRadioButton;
        private RadioButton NormalRadioButton;
        private RadioButton HardRadioButton;
        private RadioButton ImpossibleRadioButton;
        private RadioButton SuicideRadioButton;
        private Button MenuButton;
    }
}