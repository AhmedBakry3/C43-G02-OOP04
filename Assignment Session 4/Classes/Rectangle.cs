namespace Assignment_Session_4.Classes
{
    internal class Rectangle
    {
        #region Properties
        public int Height { get; set; }
        public int Width { get; set; }
        #endregion

        #region Constructors

        //A parameterless constructor that sets the width and height to 0.
        public Rectangle()
        {
            Height = default;
            Width = default;
        }

        //A constructor that accepts width and height as integers.

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }


        //A constructor that accepts a single integer and sets both width and height to that value.

        public Rectangle(int Number)
        {
            Height = Width = Number;
        }

        //override in tostring() Method
        public override string ToString()
        {
            return $"Height = {Height} , Width = {Width}";
        }
        #endregion
    }
}
