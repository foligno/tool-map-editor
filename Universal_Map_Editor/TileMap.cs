using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Universal_Map_Editor
{
    class TileMap
    {
        public int width = 100;
        public int height = 20;
        public int[,] mapData;

        public TileMap(int mapWidth, int mapHeight)
        {
            this.width = mapWidth;
            this.height = mapHeight;
            this.mapData = new int[mapWidth, mapHeight];
        }
    }
}
