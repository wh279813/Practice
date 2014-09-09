using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class WalletThingBase
    {
        protected readonly int MaxLength = 10;
        protected readonly int MaxWidth = 7;
        protected readonly int MaxThickness = 1;

        private int _length = 0;
        public int Length
        {
            get { return this._length; }
            set
            {
                if (value <= 0 || value > this.MaxLength)
                {
                    throw new ArgumentException("Length is invalid.");
                }

                this._length = value;
            }

        }

        private int _width = 0;
        public int Width
        {
            get { return this._width; }
            set
            {
                if (value <= 0 || value > this.MaxWidth)
                {
                    throw new ArgumentException("Width is invalid.");
                }

                this._width = value;
            }
        }

        private int _thickness = 0;
        public int Thickness
        {
            get { return this._thickness; }
            set
            {
                if (value <= 0 || value > this.MaxThickness)
                {
                    throw new ArgumentException("Thickness is invalid.");
                }

                this._thickness = value;
            }
        }

        public WalletThingBase(int length, int width, int thickness)
        {
            this.Length = length;
            this.Width = width;
            this.Thickness = thickness;
        }
    }
}
