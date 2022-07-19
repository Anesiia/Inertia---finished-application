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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
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
    }
}
