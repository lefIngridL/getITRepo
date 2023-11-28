namespace Organ_Transplant;

public class Organ
{
    public string Type { get; set; }
    public double HealthScore { get; set; }


    public Organ(string type, double healthScore)
    {
        Type = type;
        HealthScore = healthScore;
    }
}