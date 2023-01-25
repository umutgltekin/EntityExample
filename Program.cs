using ConsoleApp5.data;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var context=new udemycontext();

            //     context.Products.Add(new data.Product
            // {
            //     Name = "telefon",
            //     Price = 2052
            // });
            // context.Products.Add(new data.Product
            // {
            //     Name = "tablet",
            //     Price = 475

            // });
            // context.Products.Add(new data.Product     // veri tabanına eklme 
            // {
            //     Name = "araba",
            //     Price = 100000

            // });
            // context.Products.Add(new data.Product
            // {
            //     Name = "bilgisayar",
            //     Price = 25000

            // });

            // context.SaveChanges();


            //Ienumerable sorgu
            var context = new udemycontext();
            var blog = context.Products.AsEnumerable();
            //blog.Where(x => x.Name.Contains("a"));
            foreach (var item in blog)
            {
                Console.WriteLine(item.Name);
            }
            //query sorgu 
            var query=context.Products.AsQueryable();

            context.Products.SingleOrDefault(x => x.ProductId == 1);
         
 
        }
    
    }
}