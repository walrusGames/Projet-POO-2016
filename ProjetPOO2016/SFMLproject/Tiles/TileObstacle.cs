﻿using SFMLproject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;

using SFML.Audio;
using SFML.Graphics;
using SFML.Window;

using SFMLproject.StaticFields;

namespace SFMLproject.Tiles
{
    class TileObstacle : Tile
    {
        public TileObstacle(Sprite spr) : base(spr) {}

        public override void tileEvent()
        { /*Ne ait rien*/}

        public override bool updateOnInteract() { return true; }
        public override bool updateOnOccupy() { return false; }

        public override void updateOnLeave(Vector2i move) { }
        public override void updateOnReact(Vector2i ind)
        { /*Ne ait rien*/}
        public override void updateOnAction() { Console.WriteLine("Action Button Pressed - Obstacle tile"); }
    }
}
