namespace ClassBoxData

{
    using System;
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double Volume()
        {
            double volume = this.Height * this.Length * this.Width;
            return volume;
        }

        public double LateralSurafaceArea()
        {
            double latArea = 2 * this.Height * (this.Length + this.Width);
            return latArea;
        }

        public double SurfaceArea()
        {
            double area = LateralSurafaceArea() + 2 * (this.Length * this.Width);
            return area;
        }

        public override string ToString()
        {
            return $"Surface Area - {this.SurfaceArea():F2}\nLateral Surface Area - {this.LateralSurafaceArea():F2}\nVolume - {this.Volume():F2}";
        }
    }
}
