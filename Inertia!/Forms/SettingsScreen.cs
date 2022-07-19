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
using WMPLib;

namespace Inertia_
{
    public partial class SettingsScreen : Form
    {
        private static SettingsRepository settingsRepository = new SettingsRepository();

        public SettingsScreen()
        {
            InitializeComponent();
            Settings settings = settingsRepository.GetAllSettings();
            if (settings.IsMusicEnabled)
                MusicOnRadioButton.Checked = true;
            else
                MusicOffRadioButton.Checked = true;
        }

        public static void ApplySettings()//применяем заданные настройки
        {
            var settings = settingsRepository.GetAllSettings();
            (Field.Height, Field.Width) = Difficulty.ApplyDifficultySettings(); 
            if (settings.IsMusicEnabled)
                Program.musicPlayer.controls.play();
            else Program.musicPlayer.controls.stop();
        }

        private void OpenInstruction(object sender, EventArgs e)
        {
            new InstructionScreen().Show();
            Hide();
        }

        private void ChooseDifficulty(object sender, EventArgs e)
        {
            new Difficulty().Show();
            Hide();
        }

        private void MusicOnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Program.musicPlayer.controls.play();
        }

        private void MusicOffRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Program.musicPlayer.controls.stop();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Settings settings = settingsRepository.GetAllSettings();
            if (MusicOnRadioButton.Checked)
                settings.IsMusicEnabled = true;
            else settings.IsMusicEnabled = false;
            settingsRepository.Update(settings);
            new Menu().Show();
            Hide();
        }
    }
}
