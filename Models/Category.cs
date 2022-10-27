using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_homework_25._10._2022.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Product> products { get; set; }
}
}
