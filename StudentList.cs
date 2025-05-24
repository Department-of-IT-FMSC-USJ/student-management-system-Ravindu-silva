using System;

public class StudentList
{
    private Student head;

    public void Insert(Student newStudent)
    {
        if (head == null || head.IndexNumber > newStudent.IndexNumber)
        {
            newStudent.Next = head;
            head = newStudent;
            return;
        }

        Student current = head;
        while (current.Next != null && current.Next.IndexNumber < newStudent.IndexNumber)
        {
            current = current.Next;
        }

        newStudent.Next = current.Next;
        current.Next = newStudent;
    }

    public Student Search(int indexNumber)
    {
        Student current = head;
        while (current != null)
        {
            if (current.IndexNumber == indexNumber)
                return current;
            current = current.Next;
        }
        return null;
    }

    public void Remove(int indexNumber)
    {
        if (head == null)
            return;

        if (head.IndexNumber == indexNumber)
        {
            head = head.Next;
            return;
        }

        Student current = head;
        while (current.Next != null && current.Next.IndexNumber != indexNumber)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void PrintAll()
    {
        Student current = head;
        while (current != null)
        {
            Console.WriteLine($"Index Number: {current.IndexNumber}, Name: {current.Name}, GPA: {current.GPA}, Admission Year: {current.AdmissionYear}, NIC: {current.NIC}");
            current = current.Next;
        }
    }
}
