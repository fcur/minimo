namespace LocationApi.Models;

[Serializable]
public sealed class Location
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
}
