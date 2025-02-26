namespace CalculatorClassLibrary
{
    public class Calculator
    {
        
            /// <summary>
            /// Adds two numbers.
            /// </summary>
            /// <param name="a">første tal</param>
            /// <param name="b">andet tal</param>
            /// <returns>summen af a and b lagt sammen</returns>
            public double Add(double a, double b)
            {
                return a + b;
            }

            /// <summary>
            /// minuser de to tal
            /// </summary>
            /// <param name="a">førte tal</param>
            /// <param name="b">andet tal</param>
            /// <returns>resultate af a - b</returns>
            public double Subtract(double a, double b)
            {
                return a - b;
            }

            /// <summary>
            /// ganger de tal
            /// </summary>
            /// <param name="a">første tal</param>
            /// <param name="b">andet tal</param>
            /// <returns>resultatet af a and b ganget sammen</returns>
            public double Multiply(double a, double b)
            {
                return a * b;
            }

            /// <summary>
            /// dividerer de to tal sammen
            /// </summary>
            /// <param name="a">første tal</param>
            /// <param name="b">andet tal</param>
            /// <returns>quotienten af de to tal a and b divideret sammen</returns>
            /// <exception cref="DivideByZeroException">kaster en exception hvis det er at tælleren er 0.</exception>
            public double Divide(double a, double b)
            {
                if (b == 0)
                    throw new DivideByZeroException("nævneren kan ikke være 0");
                return a / b;
            }
        
    }
}
