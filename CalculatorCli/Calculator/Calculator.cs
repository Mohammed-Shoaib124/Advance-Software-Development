namespace Calculator
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            checked
            {
                return x + y;
            }
        }

        public static double Divide(int x, int y)
        {
            if(y == 0)
            {
                throw new ArgumentException("Diivide by 0");
            }
            return (double)x / (double)y; 

            
        }

        public static int Subtract(int x, int y)
        {
            checked
            {
                return x - y;
            }
            
        }

        public static int Multiply(int x, int y)
        {
            checked
            {
                return x * y;
            }
            
        }

    }
}
