namespace Task15._1;

public class VegetableShop
{
    private List<Vegetable> _products;

    public VegetableShop()
    {
        _products = new List<Vegetable>();
    }

    public void AddProducts(List<Vegetable> newProducts)
    {
        _products.AddRange(newProducts);
        Console.WriteLine($"{_products.GetType().Name} vegetables added");
    }

    public void DisplayProductsInfo()
    {
        if (_products.Count == 0)
        {
            Console.WriteLine("The shop is empty!");
            return;
        }
        
        Console.WriteLine("\nProduct in the shop:");
        decimal totalPrice = 0;

        foreach (var product in _products)
        {
            decimal price = product.Price;
            totalPrice += price;
            Console.WriteLine($"{_products.GetType().Name} vegetables price: {price} $");
        }

        Console.WriteLine($"Total price: {totalPrice} $");
    }
}

