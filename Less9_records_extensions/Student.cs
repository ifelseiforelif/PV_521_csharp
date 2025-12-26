namespace Less9_records_extensions;

public sealed class Student
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; } = String.Empty;
    public string Surname { get; set; } = String.Empty;
    public string Group { get; set; } = String.Empty;
    public override string ToString()
    {
        return $"ID: {Id}. Name: {Name} Group: {Group}";
    }
    public Student(string name, string surname, string group)
    {
        Name = name;
        Surname = surname;
        Group = group;
    }
}
