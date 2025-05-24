using System;

public class Program
{
    public static void Main(string[] args)
    {
        StudentList studentList = new StudentList();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Insert Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Print All Students");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Index Number: ");
                    int indexNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter GPA: ");
                    double gpa = double.Parse(Console.ReadLine());
                    Console.Write("Enter Admission Year: ");
                    int admissionYear = int.Parse(Console.ReadLine());
                    Console.Write("Enter NIC: ");
                    string nic = Console.ReadLine();
                    Student newStudent = new Student(indexNumber, name, gpa, admissionYear, nic);
                    studentList.Insert(newStudent);
                    break;
                case 2:
                    Console.Write("Enter Index Number to Search: ");
                    indexNumber = int.Parse(Console.ReadLine());
                    Student foundStudent = studentList.Search(indexNumber);
                    if (foundStudent != null)
                    {
                        Console.WriteLine($"Found Student - Index Number: {foundStudent.IndexNumber}, Name: {foundStudent.Name}, GPA: {foundStudent.GPA}, Admission Year: {foundStudent.AdmissionYear}, NIC: {foundStudent.NIC}");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;
                case 3:
                    Console.Write("Enter Index Number to Remove: ");
                    indexNumber = int.Parse(Console.ReadLine());
                    studentList.Remove(indexNumber);
                    break;
                case 4:
                    studentList.PrintAll();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
