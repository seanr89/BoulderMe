
namespace Domain;

public record Location
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Active { get; set; } = false;
}