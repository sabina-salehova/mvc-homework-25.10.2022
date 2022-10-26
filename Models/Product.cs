using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_homework_25._10._2022.Models
{
    public class Product
    {
        public int id { get; set; }

        public string title { get; set; }
        public Categories category { get; set; }
        public string description { get; set; }

        public double price { get; set; }

        public Colors color { get; set; }

        public Gender gender { get; set; }

        public Brand brand { get; set; }

        public string image { get; set; }

    }
}
