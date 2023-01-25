using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.data
{
    [Table(name:"product")]
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        public List<saleHistory> sale { get; set; }//one to many
        public ProductDetail productDetail { get; set; }//one to one 
        public List<categoryProduct> categoryProducts { get; set; }//many to many

        public decimal Price { get; set; }

    }
}
