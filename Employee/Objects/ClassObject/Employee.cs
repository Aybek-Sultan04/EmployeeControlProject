namespace Employee.Objects.ClassObject;
internal class Employee : IEmployee
{
    private string? name;
    private byte age;
    private string? jobTitle;
    private decimal saley;
    public string JobTitle
    {
        get => jobTitle ?? "secret";
        set
        {
            if (value.Length > 3) jobTitle = value;
            else jobTitle = "secret";
        }
    }
    public decimal Salary
    {
        get => saley != 0 ? saley : 517000;
        set
        {
            if (value > 0) { saley = value; }
            else saley = 517000;
        }
    }
    public DateOnly Hire_Time { get; set; }
    public string Name
    {
        get => name ?? "No name";
        set
        {
            if (value.Length > 3) name = value;
            else name = "No name";
        }
    }
    public byte Age
    {
        get => age;
        set
        {
            if (age > 18) age = value;
            else age = 18;
        }
    }
    public DateOnly DateOfBirthd { get; set; }
    public Guid PassportID { get; set; }
}
