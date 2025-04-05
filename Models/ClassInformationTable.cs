namespace DotNetWeek5App.Models
{
    public class ClassInformationTable
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int StudentCount { get; set; }
        public string Description { get; set; }
    }
}public class ClassInformationTable
{
    public int Id { get; set; }
    public string ClassName { get; set; }
    public int StudentCount { get; set; }
    public string Description { get; set; }

    public ClassInformationTable() { }

    public ClassInformationTable(int id, string className, int studentCount, string description)
    {
        Id = id;
        ClassName = className;
        StudentCount = studentCount;
        Description = description;
    }

    public override string ToString()
    {
        return $"Id: {Id}, ClassName: {ClassName}, StudentCount: {StudentCount}, Description: {Description}";
    }
}