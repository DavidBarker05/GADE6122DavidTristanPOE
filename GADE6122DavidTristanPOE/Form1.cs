using System;
using System.Windows.Forms;

namespace GADE6122DavidTristanPOE
{
    public partial class Form1 : Form
    {

        private GameEngine gameEngine; // Game engine
        // The booleans are to make sure player presses onlu one key once
        bool wPressed = false, dPressed = false, sPressed = false, aPressed = false; // Booleans to show if buttons are already being pressed
        private bool keyPressed = false; // Boolean for if any key is pressed

        public Form1()
        {
            // Keyboard input
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            InitializeComponent();
            gameEngine = new GameEngine(10); // Make 10 max levels
            UpdateDisplay(); // Update to show level
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            GameEngine.Direction direction = GameEngine.Direction.None;
            switch ((char)e.KeyValue) // Check key input and make direction correspond to key
            {
                case 'W':
                    direction = GameEngine.Direction.Up;
                    wPressed = true;
                    break;
                case 'D':
                    direction = GameEngine.Direction.Right;
                    dPressed = true;
                    break;
                case 'S':
                    direction = GameEngine.Direction.Down;
                    sPressed = true;
                    break;
                case 'A':
                    direction = GameEngine.Direction.Left;
                    aPressed = true;
                    break;
            }
            if (!keyPressed) gameEngine.TriggerMovement(direction); // Move only if no movement keys are already pressed
            keyPressed = wPressed || dPressed || sPressed || aPressed; // Set key pressed to be if any key pressed, but after movement to ensure the player moves
            UpdateDisplay(); // Update display to show movement
        }

        // Reset that a key is pressed when it is release
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
            lblDisplay.Text = gameEngine.ToString(); // Show level
            lblLevelNumber.Text = $"LEVEL {gameEngine.CurrentLevelNumber} OF {gameEngine.LevelAmt}"; // Show level number
        }

    }
}
