using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5.Interface.Models
{
    public delegate void UpdateAmount(float oldV,  float newV);
     class Payment : ITax
    {
        public event UpdateAmount AmountChanged;
        private float amount;

        public float _Amount { get => amount; set => amount = value; }

        public float Amount
        {
            get => _Amount;
            set
            {
                if (value != _Amount)
                {
                    if (AmountChanged != null)
                    {
                        AmountChanged(_Amount, value);
                        _Amount = value;
                    }
                }
            }
        }

        public float ComputeTax()
        {
            float tax = (float)0.1*_Amount;
            return tax;
        }
    }
}
