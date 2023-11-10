public class Character
{
    public int Id { get; set; }

    // Frodo is the default name of the character 
    public string Name { get; set; } = "Frodo";

    public int HitPoints { get; set; } = 100;

    public int Strength { get; set; } = 10;

    public int Defense { get; set; } = 10;

    public int Intelligence { get; set; } = 10;
    public rpgClass Class { get; set; } = RpgClass.Knight;
}