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

    public override string ToString()
    {
        return "{name}: p - {protein}%, c - {carbs}%, f - {fat}%";
    }
}