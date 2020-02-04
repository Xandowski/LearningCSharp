using System;

namespace Student
{
  class Program
  {
    static void Main(string[] args)
    {
      StudentGrades[] students = new StudentGrades[2];

      NewStudent(students);

    }

    public static void NewStudent(StudentGrades[] students)
    {
      int count;
      int i = 0;
      StudentGrades student;

      do
      {
        Console.WriteLine("Register another student?");
        Console.WriteLine("1 - Yes\n2 - No");
        count = int.Parse(Console.ReadLine());

        if (count == 1)
        {
          Console.WriteLine("Name:");
          string name = Console.ReadLine();

          Console.WriteLine("Grade1:");
          var grade1 = double.Parse(Console.ReadLine());
          Console.WriteLine("Grade2:");
          var grade2 = double.Parse(Console.ReadLine());
          Console.WriteLine("Grade3:");
          var grade3 = double.Parse(Console.ReadLine());
          Console.WriteLine("Grade4:");
          var grade4 = double.Parse(Console.ReadLine());

          student = new StudentGrades(name, grade1, grade2, grade3, grade4);
          students[i] = student;
          i++;

          Console.WriteLine($"Student: {student.Name} - Grade1: {student.Grade1}");
        }

      } while (count == 1);


    }

  }
}
