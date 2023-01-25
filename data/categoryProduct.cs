using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.data
{
    public class categoryProduct
    {
        public int id { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public Product product { get; set; }
        public int ProductId { get; set; }
    }
}
