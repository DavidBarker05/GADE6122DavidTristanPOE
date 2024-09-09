using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122DavidTristanPOE
{
    //Q3.1
    internal class WallTile : Tile
    {
        public WallTile(int x, int y) : base(x, y)
        {
        }

        //?
        public override char Display => throw new NotImplementedException();
    }
}
