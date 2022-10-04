using PizzaPortal.Entities;

namespace PizzaPortal.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    Id = "01",
                    Name = "Veggie Pizza",
                    Price =510,
                    Photo = "Green.jfif"
                },

                new Product
                {
                    Id = "02",
                    Name = "Pepperoni Pizza",
                    Price =520,
                    Photo = "Red.jfif"
                },
                new Product
                {
                    Id = "03",
                    Name = "Margherita Pizza",
                    Price =530,
                    Photo = "Yellow.jfif"
                },
                new Product
                {
                    Id = "04",
                    Name = "BBQ Chicken Pizza",
                    Price =540,
                    Photo = "Brown.jfif"
                },
                new Product
                {
                    Id = "05",
                    Name = "Cheesy Pizza",
                    Price =550,
                    Photo = "Blue.jfif"
                },
                new Product
                {
                    Id = "06",
                    Name = "Peri Peri Pizza",
                    Price =560,
                    Photo = "Cyan.jfif"
                }
            };
        }
        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            //return Products.Where(p => p.Id == id).FirstOrDefault();
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
