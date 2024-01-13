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

    public string GetName()
    {
        return name;
    }

    public int GetProtein()
    {
        return protein;
    }

    public int GetCarbs()
    {
        return carbs;
    }

    public int GetFat()
    {
        return fat;
    }
}
	
