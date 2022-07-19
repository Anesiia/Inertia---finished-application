using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inertia_.Storage
{
    public class Settings
    {
        public bool IsMusicEnabled { get; set; }

        public string Difficulty { get; set; }

        public Settings()
        {
            IsMusicEnabled = true;
            Difficulty = "Easy";
        }
    }
}
