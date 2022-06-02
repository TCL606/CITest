using System;

namespace CSharp_Calculation
{
    public class Sub<T> : Operation<T> where T: struct
    {
        public override T Operate(T num1, T num2)
        {
            if (typeof(T) == typeof(int))
            {
                int a = (int)Convert.ChangeType(num1, typeof(int));
                int b = (int)Convert.ChangeType(num2, typeof(int));

                int c = a - b;
                return (T)Convert.ChangeType(c, typeof(T));
            }
            else if (typeof(T) == typeof(float))
            {
                float a = (float)Convert.ChangeType(num1, typeof(float));
                float b = (float)Convert.ChangeType(num2, typeof(float));

                float c = a - b;
                return (T)Convert.ChangeType(c, typeof(T));
            }
            else if (typeof(T) == typeof(double))
            {
                double a = (double)Convert.ChangeType(num1, typeof(double));
                double b = (double)Convert.ChangeType(num2, typeof(double));

                double c = a - b;
                return (T)Convert.ChangeType(c, typeof(T));
            }
            else if (typeof(T) == typeof(decimal))
            {
                decimal a = (decimal)Convert.ChangeType(num1, typeof(decimal));
                decimal b = (decimal)Convert.ChangeType(num2, typeof(decimal));

                decimal c = a - b;
                return (T)Convert.ChangeType(c, typeof(T));
            }

            return default(T);
        }
    }
}