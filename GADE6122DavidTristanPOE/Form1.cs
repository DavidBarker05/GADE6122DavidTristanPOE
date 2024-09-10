using System;
using System.Windows.Forms;

namespace GADE6122DavidTristanPOE
{
    public partial class Form1 : Form
    {

        private GameEngine gameEngine;
        bool wPressed = false, dPressed = false, sPressed = false, aPressed = false;
        private bool keyPressed = false;

        public Form1()
        {
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            InitializeComponent();
            gameEngine = new GameEngine(10);
            UpdateDisplay();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Direction direction = Direction.None;
            switch ((char)e.KeyValue)
            {
                case 'W':
                    direction = Direction.Up;
                    wPressed = true;
                    break;
                case 'D':
                    direction = Direction.Right;
                    dPressed = true;
                    break;
                case 'S':
                    direction = Direction.Down;
                    sPressed = true;
                    break;
                case 'A':
                    direction = Direction.Left;
                    aPressed = true;
                    break;
            }
            if (!keyPressed) gameEngine.TriggerMovement(direction);
            keyPressed = wPressed || dPressed || sPressed || aPressed;
            UpdateDisplay();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch ((char)e.KeyValue)
            {
                case 'W':
                    wPressed = false;
                    break;
                case 'D':
                    dPressed = false;
                    break;
                case 'S':
                    sPressed = false;
                    break;
                case 'A':
                    aPressed = false;
                    break;
            }
            keyPressed = wPressed || dPressed || sPressed || aPressed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateDisplay()
        {
            lblDisplay.Text = gameEngine.ToString();
        }

    }
}
