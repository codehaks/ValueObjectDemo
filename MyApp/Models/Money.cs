using System;
using System.Collections.Generic;
using System.Text;


namespace Portal.Domain.Values
{
    public class Money
    {
        public Money(int value)
        {
            if (value >= 0)
            {
                Value = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Can not be less than 0");
            }
        }
        public int Value { get; private set; }

    }
}
