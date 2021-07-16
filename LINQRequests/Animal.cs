using System;
using System.Collections.Generic;
using System.Text;

namespace LINQRequests
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public void voice()
        {
            Console.WriteLine($"{this.Name}:voice!");
        }

    }
}
