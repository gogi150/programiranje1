public class FoodType
{
    private string name;
    private int protein;
    private int carbs;
    private int fat;

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

    public override string ToString()
    {
        return "{type.Name}: p - {type.Protein}%, c - {type.Carbs}%, f - {type.Fat}%, w - {weight}g";
    }
}
