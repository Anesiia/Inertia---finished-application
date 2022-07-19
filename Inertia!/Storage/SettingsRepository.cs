using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inertia_.Storage
{
    internal class SettingsRepository
    {
        private const string settingsLocation = @"Resources\Json\Settings.json";

        private static Serialization serialization = new Serialization();

        public Settings GetAllSettings()
        {
            var settings = serialization.Deserialize<Settings>(settingsLocation);
            if (settings is null)
            {
                settings = new Settings(); //создание настроек по умолчанию, если файл пуст
                Update(settings);
            }
            return settings;
        }

        public void Update(Settings settings)
        {
            serialization.Serialize(settings, settingsLocation);
        }
    }
}
