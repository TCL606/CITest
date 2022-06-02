using System;

namespace CSharp_Calculation
{
    public abstract class Operation<T> where T : struct
    {
        public abstract T Operate(T num1, T num2);
    }
}