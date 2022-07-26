using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inertia_.Storage;

namespace Inertia_
{
    public partial class Difficulty : Form
    {
        private static SettingsRepository settingsRepository = new SettingsRepository();

        public enum levelOfDifficulty
        {
            Easy,
            Normal,
            Hard,
            Impossible,
            Suicide
        }
        public Difficulty()
        {
            InitializeComponent();

            var settings = settingsRepository.GetAllSettings();
            ApplyDifficultySettings();
            foreach (RadioButton radioButton in Controls.OfType<RadioButton>())
            {
                if ((levelOfDifficulty)radioButton.Tag == settings.Difficulty)
                    radioButton.Checked = true;
            }
        }

        public static (int, int) ApplyDifficultySettings()
        {
            Settings settings = settingsRepository.GetAllSettings();
            (Field.Width, Field.Height) = settings.Difficulty switch
            {
                levelOfDifficulty.Easy => (9, 10),
                levelOfDifficulty.Normal => (10, 11),
                levelOfDifficulty.Hard => (12, 13),
                levelOfDifficulty.Impossible => (14, 15),
                levelOfDifficulty.Suicide => (15, 16),
            };
            return (Field.Width, Field.Height);
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Settings settings = settingsRepository.GetAllSettings();

            foreach (RadioButton radioButton in Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                    settings.Difficulty = (levelOfDifficulty)radioButton.Tag;
            }
            settingsRepository.Update(settings);

            new Menu().Show();
            Hide();
        }

        private void Difficulty_Load(object sender, EventArgs e)
        {

        }
    }
}
