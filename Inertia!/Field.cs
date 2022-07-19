using Inertia_.ElementsOfField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Inertia_
{
    public class Field
    {
        public static int Width = 9;
        public static int Height = 9;
        public int prizesOnField;
        public Element[,] Matrix = new Element[Width, Height];
        public Player? player;///ЕЩЕ РАЗ ПРОЧИТАТЬ

        public Element this[int x, int y]//віход за границу поля
        {
            get => Matrix[x, y];
            set
            {
                if (value is Player) // добавление игрока на карту
                {
                    player = new Player(value.X, value.Y);
                }

                if (value is Prize) // добавление приза на карту
                {
                    prizesOnField++;
                }

                if (Matrix[x, y] is Prize) // удаления приза с карты
                {
                    prizesOnField--;
                }

                Matrix[x, y] = value;
            }
        }

        public void CreateField()
        {
            Random random = new Random();

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (IsOnFieldBorders(x, y))
                    {
                        this[x, y] = new Wall(x, y);
                    }

                    else
                        this[x, y] = random.Next(0, 100) switch
                        {
                            < 5 => new Wall(x, y),
                            < 10 => new Trap(x, y),
                            < 20 => new Prize(x, y),
                            < 35 => new Stop(x, y),
                            _ => new Empty(x, y)
                        };
                }
            }

            this[Width / 2, Height - 2] = new Player(Width / 2, Height - 2);

            if (prizesOnField == 0) // если на карте не появился приз, создаём его в случайном месте
            {
                var (x, y) = (random.Next(1, Width - 2), random.Next(1, Height - 2));

                while (x == player.X && y == player.Y) // чтоб приз случайно не поставился вместо игрока
                    (x, y) = (random.Next(1, Width - 2), random.Next(1, Height - 2));

                this[x, y] = new Prize(x, y);
            }
        }

        private static bool IsOnFieldBorders(int x, int y)
        {
            return x == 0 || x == Width - 1 || y == 0 || y == Height - 1;
        }
    }
}
