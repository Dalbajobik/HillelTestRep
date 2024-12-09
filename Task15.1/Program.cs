using Task15._1;
using System.Collections.Generic;
var products = new List<Vegetable>()

{
    new Carrot(15),
    new Potato(20, 4),
    new Cucumber(14, 2)
};


VegetableShop shop = new VegetableShop();

shop.AddProducts(products);

shop.DisplayProductsInfo();