﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2.Model
{
    public class Terminator : Shape
    {
        public Terminator(int ID, string ShapeName, string Literal, int X, int Y, int Shape_Height, int Shape_Width)
        {
            this.ID = ID;
            this.ShapeName = ShapeName;
            this.Literal = Literal;
            this.X = X;
            this.Y = Y;
            this.Shape_Height = Shape_Height;
            this.Shape_Width = Shape_Width;
        }
    }
}
