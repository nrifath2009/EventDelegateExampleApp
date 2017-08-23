using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateDemo
{
    
    public class Calculator
    {
        public delegate void MyEventRaiser();
        public event MyEventRaiser OnMultipleOfFiveReached;

        public int Add(int firstNumber,int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            if((sum%5==0) && (OnMultipleOfFiveReached != null))
            {
                OnMultipleOfFiveReached();
            }
            return sum;
        }
    }
    
    
}
