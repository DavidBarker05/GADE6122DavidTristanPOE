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
        public Form1()
        {
            InitializeComponent();
        }

        //Q2.1
        //Class Position created for storing x and y coordinates for a singular tile on the map 
        internal class Position
        {
            private int positionX;
            private int positionY;

            //constructor accepting x and y integer parameters
            public Position(int x, int y)
            {
                this.positionX = x;
                this.positionY = y;
            }

            //properties for x and y coordinates allowing access and modification of backing fields 
            public int PositionX { get { return positionX; } }

            public int PositionY { get { return positionY; } }

        }
        //Q2.2
        internal abstract class Tile
        {
            private int positionType;
            private int positionX, positionY;

            public int PositionX { get { return positionX; } }

            public int PositionY { get { return positionY; } }

            public Tile(int x, int y)
            {
                this.positionX = PositionX;
                this.positionY = PositionX;
            }

            public abstract char Display { get; }


        }
        //Q2.3
        internal class EmptyTile : Tile
        {
            public EmptyTile(Position position, string positionType)
                : base(position.PositionX, position.PositionY)
            {
            }
            public EmptyTile(Position position)
                : base(position.PositionX, position.PositionY)
            {

            }

            public string positionType { get; set; }


            public override char Display => '.';
        }

        //Q2.4
        internal class level
        {
            static string[] Tile = { "Width", "Height" };

            int resultX = Int32.Parse(Tile[0]);
            int resultY = Int32.Parse(Tile[1]);

            int positionX, positionY;

            public level(int reslutX, int resultY)
            {
                this.resultX = positionX;
                this.resultY = positionY;

                positionX = 0;
                positionY = 0;

            }
            enum TileType
            {
                EmptyTile,
            }

            private void CreateTile(int TileType, int Position)
            {
                Object tile = new Object();

                switch (TileType)
                {
                    case int EmptyTile:
                        break;
                }

                //int EmpryTile = Tile[];

                return;
            }

            static void InitialiseTiles()
            {
                //?
            }
            public override string ToString()
            {
                return base.ToString();
            }
        }

        internal class GameEngine
        {
            private int levelAmt;
            private int numLevel;

            private Random rnd = new Random();

            const int minSize = 10;
            const int maxSize = 20;


            public GameEngine(int levelAmt)
            {
                this.levelAmt = 0;
                //?
                return;
            }

            public override string ToString()
            {
                return base.ToString();
            }
            //?
            //private int GameEngine { get { return (int)levelAmt; } }
        }

        //Q3.1
        internal class WallTile : Tile
        {
            public WallTile(int x, int y) : base(x, y)
            {
            }

            //?
            public override char Display => throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
