using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1.Models
{
    class Food
    {
        private int id;
        private string name;
        private float amount;

        public Food()
        {
        }

        public Food(int id, string name, float amount)
        {
            this.Id = id;
            this.Name = name;
            this.Amount = amount;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Amount { get => amount; set => amount = value; }

        public override string ToString()
        {
            return
                "\n|ID: " + this.Id +
                "\n|Name: " + this.Name +
                "\n|Amount: " + this.Amount + "\n";
        }
    }
}
