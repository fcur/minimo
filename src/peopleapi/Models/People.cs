namespace PeopleApi.Models;

[Serializable]
public sealed class People
{
    public Guid Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string? Middlename { get; set; }

    public string? Lastname { get; set; }
}
