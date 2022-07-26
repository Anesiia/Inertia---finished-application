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

        public Difficulty.levelOfDifficulty Difficulty { get; set; }//enum

        public Settings()
        {
            IsMusicEnabled = true;
            Difficulty = Inertia_.Difficulty.levelOfDifficulty.Easy;//
        }
    }
}
