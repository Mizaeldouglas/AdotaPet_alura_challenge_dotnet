namespace Api.Model.Tutor;

public class Tutor
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Phone { get; set; } = String.Empty;
    public string City { get; set; } = String.Empty;
    public string Avatar { get; set; } = String.Empty;
    public string About { get; set; } = String.Empty;
}