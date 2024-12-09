public abstract class Vegetable
{
    protected decimal BasePrice;
    public Vegetable(decimal basePrice)

    {
        BasePrice = basePrice;
    }
    public abstract decimal Price { get; }
}

public class Carrot : Vegetable
{
    public Carrot(decimal basePrice) : base(basePrice) { }
    public override decimal Price => BasePrice;
}

public class Potato : Vegetable
{
    private decimal count;

    public Potato(decimal basePrice, decimal count) : base(basePrice)
    {
        this.count = count;
    }
    
    public override decimal Price => BasePrice * count;
}

public class Tomato : Vegetable
{
    public Tomato(decimal basePrice) : base(basePrice) { }
    
    public override decimal Price => BasePrice;
}

public class Cucumber : Vegetable
{
    private decimal count;
    
    public Cucumber(decimal basePrice, decimal count) : base(basePrice)
    {
        this.count = count;
    }
    
    public override decimal Price => BasePrice * count;
}