namespace SoftwareSystemsMaintainance_Lab1.Components.Models;

using System.Text.Json.Serialization;

public class Answer
{
    [JsonRequired]
    public int Id { get; set; }
    
    [JsonRequired]
    public int Correct { get; set; }
    
    [JsonRequired]
    public int? Value { get; set; }
    
    public double Score
    {
        get
        {
            if (!Value.HasValue)
                return 0;
            if (Correct == 0)
                return Value.Value == 0 ? 1 : 0;
            
            double d = Math.Abs(Value.Value - Correct) / (double)Correct;
            double t = Math.Min(d, 1.0); // clamping to [0,1]
            
            // Smoothstep (inverted)
            return 1.0 - (t * t * (3.0 - 2.0 * t));
        }
    }
    
    public double Error
    {
        get
        {
            if (!Value.HasValue)
                return 1;
            
            return Math.Sign(Value.Value - Correct) * (1 - Score);
        }
    }


    public Answer(int id, int correct)
    {
        Id = id;
        Correct = correct;
    }
}