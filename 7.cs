public class FoodType
{
    private string name;
    private int protein;
    private int carbs;
    private int fat;

    public FoodType(string name, int protein, int carbs, int fat)
    {
        this.name = name;
        this.protein = protein;
        this.carbs = carbs;
        this.fat = fat;
    }

    public string Name { get { return name; } }
    public int Protein { get { return protein; } }
    public int Carbs { get { return carbs; } }
    public int Fat { get { return fat; } }
}

public class Food
{
    private FoodType type;
    private int weight;

    public Food(FoodType type, int weight)
    {
        this.type = type;
        this.weight = weight;
    }

    public double GetProtein()
    {
        return (type.Protein / 100.0) * weight;
    }

    public double GetCarbs()
    {
        return (type.Carbs / 100.0) * weight;
    }

    public double GetFat()
    {
        return (type.Fat / 100.0) * weight;
    }

    public override string ToString()
    {
        return "{type.Name}: p - {GetProtein():F1}g, c - {GetCarbs():F1}g, f - {GetFat():F1}g, w - {weight}g";
    }

    public string ToStringInGrams()
    {
        return "{type.Name}: p - {GetProtein():F1}g, c - {GetCarbs():F1}g, f - {GetFat():F1}g, w - {weight}g";
    }
}