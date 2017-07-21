using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomMezonin.DomainModel.Repository
{
    public class FakeRepository : IRepository
    {
        private Dictionary<long, Product> products;
        private Dictionary<long, Category> categories;
        private Dictionary<long, Image> images;

        public void InitializeImages()
        {
            images = new Dictionary<long, Image>()
{
{ 0, new Image()
{
Id = 0,
Path = "~/Content/Images/image1.jpg",
Height = 64,
Width = 64
}},
{ 1, new Image()
{
Id = 1,
Path = "~/Content/Images/image2.jpg",
Height = 64,
Width = 64
}},
{ 2, new Image()
{
Id = 2,
Path = "~/Content/Images/image3.jpg",
Height = 64,
Width = 64
}},
};
        }

        public void InitializeProducts()
        {
            products = new Dictionary<long, Product>()
{
{ 0, new Product()
{
Id = 0,
Name = "Лампа",
Price = 1000,
Category = categories[0],
Description = "Эта лампа поразит вас",
Size = "",
Image = images[1],
Color = "черный",
Quantity = 10
}
},
{
1, new Product()
{
Id = 1,
Name = "Красивая лампа",
Price = 5999,
Category = categories[0],
Description = "Очень красивая лампа",
Size = "",
Image = images[1],
Color = "белый",
Quantity = 7
}
},
{
2, new Product()
{
Id = 2,
Name = "Пушистая лампа",
Price = 7000,
Category = categories[1],
Description = "Эта лампа очень пушистая",
Size = "",
Image = images[1],
Color = "пушистый",
Quantity = 15
}
}
};

        }

        public void IntializeCategories()
        {
            categories = new Dictionary<long, Category>()
{
{0, new Category()
{
Id = 0,
ChildCategories = null,
Description = "Китайские сука лампы",
HasChildCategories = false,
Name = "Лампы китайские",
Image = images[0],
Products = new List<Product>(),
ParentCategory = null
}},
{1, new Category()
{
Id = 1,
ChildCategories = null,
Description = "Пиздатые лампы",
HasChildCategories = false,
Name = "Пиздатые лампы",
Image = images[1],
Products = new List<Product>(),
ParentCategory = null
}},
};
        }

        public Product GetProductById(long id)
        {
            if (products.ContainsKey(id))
            {
                return products[id];
            }
            return null;
        }


    }
}
