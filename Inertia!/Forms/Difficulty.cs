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

        private static Dictionary<string, (int, int)> difficulty = new Dictionary<string, (int, int)>()
        {
            { "Easy", (9, 10) },//задаем размер поля в соответствии с выбранной сложностью уровня
            { "Normal", (10, 11) },
            { "Hard", (12, 13) },
            { "Impossible", (14, 15) },
            { "Suicide", (15, 16) },
        };

        public Difficulty()
        {
            InitializeComponent();
            var settings = settingsRepository.GetAllSettings();
            (Field.Width, Field.Height) = settings.Difficulty switch
            {
                "Easy" => difficulty["Easy"],
                "Normal" => difficulty["Normal"],
                "Hard" => difficulty["Hard"],
                "Impossible" => difficulty["Impossible"],
                "Suicide" => difficulty["Suicide"],
            };
            foreach (RadioButton radioButton in Controls.OfType<RadioButton>())
            {
                if (radioButton.Tag.ToString() == settings.Difficulty)
                    radioButton.Checked = true;
            }
        }

        public static (int, int) ApplyDifficultySettings()
        {
            Settings settings = settingsRepository.GetAllSettings();
            return difficulty[settings.Difficulty];
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Settings settings = settingsRepository.GetAllSettings();

            foreach (RadioButton radioButton in Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                    settings.Difficulty = radioButton.Tag.ToString();
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
