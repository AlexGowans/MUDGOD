using System;
using System.Collections.Generic;
using System.Text;

namespace MUDGOD.GameEngine.WorldMap {
    class Map {
        public int sizeX = 10;
        public int sizeY = 10;

        public Tile[,] mapGrid;
    
        //create a map
        public Map() {
            mapGrid = new Tile[sizeX, sizeY];
        }
    }
}
