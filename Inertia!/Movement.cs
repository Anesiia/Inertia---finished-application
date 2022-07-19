using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Inertia_.ElementsOfField;
using Inertia_.Forms;

namespace Inertia_
{
    internal class Movement
    {
        public GameScreen gameScreen;

        public Field field;

        public Keys currentKey;

        public bool isPlayerMoving;

        public Dictionary<Keys, (int x, int y)> Coordinates = new()
        { 
            { Keys.W, (0, -1)},
            { Keys.S, (0, +1) },
            { Keys.A, (-1, 0) },
            { Keys.D, (+1, 0) },
            { Keys.E, (+1, -1) },
            { Keys.Q, (-1, -1) },
            { Keys.Z, (-1, +1) },
            { Keys.X, (+1, +1) }
        };

        public void Move(object? sender, EventArgs e)
        {
            isPlayerMoving = true;

            var (x, y) = GetNewCoordinats(currentKey, field.player.X, field.player.Y);

            switch (field[x, y])
            {
                case Prize or Stop:
                    if (field[x, y] is Prize)
                    {
                        Program.soundPlayer.URL = @"Resources\Prize.wav";
                        gameScreen.PrizesCollected++;
                    }
                    field[x, y] = new Empty(x, y);
                    gameScreen.MovePlayer(field.player, x, y);
                    if (field.prizesOnField == 0) // условие победы
                        gameScreen.Win();
                    isPlayerMoving = false;
                    break;
                case Wall:
                    isPlayerMoving = false;
                    break;
                case Trap: // условие поражения
                    isPlayerMoving = false;
                    gameScreen.GameOver();
                    break;
                default:
                    gameScreen.MovePlayer(field.player, x, y);
                    break;
            }

            if (!isPlayerMoving)
            {
                gameScreen.MovementStop();
            }
        }

        private (int x, int y) GetNewCoordinats(Keys key, int x, int y)
        {
            x += Coordinates[key].x;
            y += Coordinates[key].y;

            return (x, y);
        }
    }
}
