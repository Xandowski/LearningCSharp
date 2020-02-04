using System;
using System.Collections.Generic;

namespace Student
{
  class StudentGrades
  {
    public string Name { get; }
    public double Grade1 { get; }
    public double Grade2 { get; }
    public double Grade3 { get; }
    public double Grade4 { get; }
    public StudentGrades(string name, double grade1, double grade2, double grade3, double grade4)
    {
      this.Name = name;
      this.Grade1 = grade1;
      this.Grade2 = grade2;
      this.Grade3 = grade3;
      this.Grade4 = grade4;
    }
  }
}
