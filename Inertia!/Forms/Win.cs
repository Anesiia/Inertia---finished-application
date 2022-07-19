using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inertia_.Forms
{
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
            PrizesCollectedNumberLabel.Text = GameScreen.prizesCollected.ToString();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartGame();
            gameScreen.Show();
            Hide();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            Hide();
        }

        private void Win_Load(object sender, EventArgs e)
        {

        }
    }
}
