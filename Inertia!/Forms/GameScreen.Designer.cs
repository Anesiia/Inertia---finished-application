namespace Inertia_
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.FieldPictureBox = new System.Windows.Forms.PictureBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MovementTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreLabelNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FieldPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldPictureBox
            // 
            this.FieldPictureBox.Location = new System.Drawing.Point(-4, 0);
            this.FieldPictureBox.Name = "FieldPictureBox";
            this.FieldPictureBox.Size = new System.Drawing.Size(596, 428);
            this.FieldPictureBox.TabIndex = 0;
            this.FieldPictureBox.TabStop = false;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.MenuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuButton.Location = new System.Drawing.Point(6, 336);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(259, 38);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = "Return to main menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.ReturnToMainMenu);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScoreLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.Location = new System.Drawing.Point(-4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(214, 27);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "You current score:";
            // 
            // ScoreLabelNumber
            // 
            this.ScoreLabelNumber.AutoSize = true;
            this.ScoreLabelNumber.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabelNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScoreLabelNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabelNumber.ForeColor = System.Drawing.Color.ForestGreen;
            this.ScoreLabelNumber.Location = new System.Drawing.Point(0, 0);
            this.ScoreLabelNumber.Name = "ScoreLabelNumber";
            this.ScoreLabelNumber.Size = new System.Drawing.Size(25, 27);
            this.ScoreLabelNumber.TabIndex = 5;
            this.ScoreLabelNumber.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Inertia_.Resource1.win;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(523, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 428);
            this.panel1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(9, 163);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.ScoreLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.ScoreLabelNumber);
            this.splitContainer1.Size = new System.Drawing.Size(271, 37);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = global::Inertia_.Resource1.win;
            this.panel2.Controls.Add(this.FieldPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 428);
            this.panel2.TabIndex = 7;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.BackgroundImage = global::Inertia_.Resource1._short;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MovementStart);
            ((System.ComponentModel.ISupportInitialize)(this.FieldPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox FieldPictureBox;
        private Button MenuButton;
        private System.Windows.Forms.Timer MovementTimer;
        private Label ScoreLabel;
        private Label ScoreLabelNumber;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel2;
    }
}