namespace SoftwareSystemsMaintainance_Lab1.Components.Models;

using System.Text.Json.Serialization;

public class Question
{
    [JsonPropertyName("id")]
    [JsonRequired]
    public int Id { get; set; }
        
    [JsonPropertyName("question")]
    [JsonRequired]
    public string QuestionText { get; set; }
        
    [JsonPropertyName("correct")]
    [JsonRequired]
    public int Correct { get; set; }
}