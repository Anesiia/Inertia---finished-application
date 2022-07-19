namespace Inertia_.Forms
{
    partial class Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win));
            this.MenuButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrizesCollectedLabel = new System.Windows.Forms.Label();
            this.PrizesCollectedNumberLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.LightBlue;
            this.MenuButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuButton.Location = new System.Drawing.Point(317, 253);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(200, 51);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "To main menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.LightBlue;
            this.ContinueButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueButton.Location = new System.Drawing.Point(317, 200);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(200, 47);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(251, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 68);
            this.label1.TabIndex = 8;
            this.label1.Text = "You win!";
            // 
            // PrizesCollectedLabel
            // 
            this.PrizesCollectedLabel.AutoSize = true;
            this.PrizesCollectedLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PrizesCollectedLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizesCollectedLabel.Location = new System.Drawing.Point(1, 0);
            this.PrizesCollectedLabel.Name = "PrizesCollectedLabel";
            this.PrizesCollectedLabel.Size = new System.Drawing.Size(168, 23);
            this.PrizesCollectedLabel.TabIndex = 11;
            this.PrizesCollectedLabel.Text = "Prizes collected:";
            // 
            // PrizesCollectedNumberLabel
            // 
            this.PrizesCollectedNumberLabel.AutoSize = true;
            this.PrizesCollectedNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrizesCollectedNumberLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrizesCollectedNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.PrizesCollectedNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.PrizesCollectedNumberLabel.Name = "PrizesCollectedNumberLabel";
            this.PrizesCollectedNumberLabel.Size = new System.Drawing.Size(25, 27);
            this.PrizesCollectedNumberLabel.TabIndex = 12;
            this.PrizesCollectedNumberLabel.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(307, 141);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.PrizesCollectedLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.PrizesCollectedNumberLabel);
            this.splitContainer1.Size = new System.Drawing.Size(222, 30);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 13;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inertia_.Resource1.leto_derevo_vetki_zelen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victory";
            this.Load += new System.EventHandler(this.Win_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MenuButton;
        private Button ContinueButton;
        private Label label1;
        private Label PrizesCollectedLabel;
        private Label PrizesCollectedNumberLabel;
        private SplitContainer splitContainer1;
    }
}