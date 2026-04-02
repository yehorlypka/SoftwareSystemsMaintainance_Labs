namespace SoftwareSystemsMaintainance_Lab1.Components.Models;

using System.Text.Json.Serialization;

public class Question
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
        
    [JsonPropertyName("question")]
    public string QuestionText { get; set; }
        
    [JsonPropertyName("correct")]
    public int Correct { get; set; }
}