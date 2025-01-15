namespace Assignment_Session_4.Classes
{
    internal class Complex
    {
        #region Propertires
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Methods
        //override in tostring() Method
        public override string ToString()
        {
            return $"Complex Number = {Real} + {Img}i";
        }
        #endregion

        #region Opertaor Overloading

        //Opertaor Overloading for '+'

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Img = (Left?.Img ?? 0) + (Right?.Img ?? 0)
            };
        }

        //Opertaor Overloading for '-'
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Img = (Left?.Img ?? 0) - (Right?.Img ?? 0)
            };
        }


        #endregion



    }
}
