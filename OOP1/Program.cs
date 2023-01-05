using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Kazak";
            product1.UnitPrice = 100;
            product1.UnitPrice = 50;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 2,
                ProductName = "Ayakkabı",
                UnitPrice = 350,
                UnitInStok = 522
            };
            //PascalCase camelCase
            //Class    yenideğişken
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int,double,bool...değer tip
            //diziler,class,abstract class,interface ... referans
            //ref out nedir??

        }
    }
}
