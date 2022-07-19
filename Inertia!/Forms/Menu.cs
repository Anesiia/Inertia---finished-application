namespace Inertia_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SettingsScreen.ApplySettings();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartGame();
            gameScreen.Show();
            Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new SettingsScreen().Show();
            Hide();
        }

        private void ExitFromGameDialog(object sender, EventArgs e)//подтверждение выхода
        {
            if (MessageBox.Show("Are you sure you want to exit the game",
                    "Confirm, please :)",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}