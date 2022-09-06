using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    abstract class Shape
    {
        public Shape(int red, int blue, int yellow)
        {
            /// These 3 lines are the same across Circle, Square, Triangle. Put it to the base class
            NumberOfRedShape = red;
            NumberOfBlueShape = blue;
            NumberOfYellowShape = yellow;
        }
        
        // Make Name abstract and override it in the property area
        public abstract string Name { get; }
        // Make Price abstract field, and force children class to override it
        public abstract int Price { get; }
        // If this one is always 1, we could hardcode it in the base class. Or make AdditionalCharge virtual field
        public virtual int AdditionalCharge => 1;
        public int NumberOfRedShape { get; set; }
        public int NumberOfBlueShape { get; set; }
        public int NumberOfYellowShape { get; set; }
        public int TotalQuantityOfShape()
        {
            return NumberOfRedShape + NumberOfBlueShape + NumberOfYellowShape;
        }

        public int AdditionalChargeTotal()
        {
            return NumberOfRedShape * AdditionalCharge;
        }
        // Since 3 children have the same implementation, we can implement it here and mark it as virtual
        public virtual int Total()
        {
            return RedCirclesTotal() + BlueCirclesTotal() + YellowCirclesTotal();
        }

        public virtual int RedCirclesTotal()
        {
            return (NumberOfRedShape * Price);
        }
        public virtual int BlueCirclesTotal()
        {
            return (NumberOfBlueShape * Price);
        }
        public virtual int YellowCirclesTotal()
        {
            return (NumberOfYellowShape * Price);
        }
    }
}
