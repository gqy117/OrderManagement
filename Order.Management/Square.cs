using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Square : Shape
    {
        public override string Name => "Square";

        public override int Price => 1;

        public Square(int red, int blue, int yellow): base(red, blue, yellow)
        {
        }
    }
}
