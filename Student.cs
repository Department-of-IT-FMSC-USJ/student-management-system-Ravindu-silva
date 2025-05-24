public class Student
{
    public int IndexNumber { get; set; }
    public string Name { get; set; }
    public double GPA { get; set; }
    public int AdmissionYear { get; set; }
    public string NIC { get; set; }
    public Student Next { get; set; }

    public Student(int indexNumber, string name, double gpa, int admissionYear, string nic)
    {
        IndexNumber = indexNumber;
        Name = name;
        GPA = gpa;
        AdmissionYear = admissionYear;
        NIC = nic;
        Next = null;
    }
}
