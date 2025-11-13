public class Fraction {
            private int _top;
            private int _bottom;

        public Fraction()  //default with no parameters 1/1
        {
        _top = 1;
        _bottom = 1;
        }
        public Fraction(int top) //Whole number 5/1=5 - constructor with one parameter
        {
        _top = top;
        _bottom = 1;
        }
        public Fraction(int top, int bottom) //Constructor with 2 parameters (3/5)
        {
            _top = top;
            _bottom = bottom;
        }

        //Getters
        public int GetTop()
        {
        return _top;
        }
        public int GetBottom()
        {
        return _bottom;
        }

        //Setters
        public void SetTop(int top)
        {
            _top = top;
        }
        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

     //Methods for returning the fractions
     // Returning fraction string like "3/4"
        public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Returning decimal value
      public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

 }