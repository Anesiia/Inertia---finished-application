using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inertia_.ElementsOfField;
using Inertia_.Forms;

namespace Inertia_
{
    public partial class GameScreen : Form
    {
        private const int side = 55;

        public static Field field;

        public static int prizesCollected;

        private Movement movement;

        public int PrizesCollected
        {
            get => prizesCollected;
            set
            {
                if (prizesCollected != value)
                {
                    prizesCollected = value;
                    UpdateScore();
                }
            }
        }

        public GameScreen()
        {
            InitializeComponent();
            field = new Field();
            movement = new Movement();
            MovementTimer.Interval = 100;
            MovementTimer.Tick += movement.Move;
            ScoreLabelNumber.Text = PrizesCollected.ToString();
            FieldPictureBox.Size = new Size(Field.Width * side, Field.Height * side);

        }

        public void StartGame()
        {
            FieldPictureBox.Controls.Clear();

            field = new Field();
            field.CreateField();
            FieldPrint();

            movement.field = field;
            movement.gameScreen = this;
        }

        public void Win()
        {
            new Win().Show();
            Hide();
        }

        public void GameOver()
        {
            new GameOver().Show();
            Hide();
        }

        public void MovePlayer(Player player, int x, int y)//очищаем пикчербокс игрока и пикчербокс на новых координатах
        {
            RemovePictureBoxOnCoords(player.X, player.Y);
            RemovePictureBoxOnCoords(x, y);

            player.X = x;
            player.Y = y;
            CreatePictureBox(player);
        }

        public void MovementStart(object sender, KeyEventArgs e)//принимать ввод только если это правильная клавиша и игрок стоит на месте
        { 
            if (movement.Coordinates.ContainsKey(e.KeyCode) && movement.isPlayerMoving == false)
            {
                movement.currentKey = e.KeyCode;
                MovementTimer.Start();
            }
        }

        public void MovementStop()
        {
            MovementTimer.Stop();
        }

        private void FieldPrint()
        {
            for (int y = 0; y < Inertia_.Field.Height; y++)
            {
                for (int x = 0; x < Inertia_.Field.Width; x++)
                {
                    CreatePictureBox(field[x, y]);
                }
            }
        }

        private void CreatePictureBox(Element element)
        {
            PictureBox pictureBox = new PictureBox()
            {
                Image = DefineImageOfObject(element),
                Location = new Point(element.X * side, element.Y * side),
                Size = new Size(side, side),
                SizeMode = PictureBoxSizeMode.Zoom,
                Parent = FieldPictureBox
            };
           
            FieldPictureBox.Controls.Add(pictureBox);
        }

        private Image DefineImageOfObject(Element element)//определяем изображение к каждому элементу
        {
            return element switch
            {
                Wall => Resource1.wall,
                Prize => Resource1.nut,
                Trap => Resource1.trap,
                Stop => Resource1.tree,
                Player => Resource1.squirrrel,
                _ => Resource1.empty
            };
        }

        private PictureBox FindPictureBox(Point location)//ищем пикчербокс по координатам
        {
            foreach (Control control in FieldPictureBox.Controls)
            {
                if (control.Location == location)
                {
                    return control as PictureBox;
                }
            }
            
            return null;
        }

        private void RemovePictureBoxOnCoords(int x, int y)//удаляем пикчербокс по координатам
        {
            var location = new Point(x * side, y * side);
            var pictureBox = FindPictureBox(location);
            FieldPictureBox.Controls.Remove(pictureBox);
        }

        private void UpdateScore()
        {
            ScoreLabelNumber.Text = PrizesCollected.ToString();
        }

        private void ReturnToMainMenu(object sender, EventArgs e)
        {
            new Menu().Show();
            Hide();
        }
    }
}
