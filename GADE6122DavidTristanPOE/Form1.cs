using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6122DavidTristanPOE
{
    public partial class Form1 : Form
    {

        private GameEngine gameEngine;

        public Form1()
        {
            InitializeComponent();
            gameEngine = new GameEngine(10);
            UpdateDisplay();
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
