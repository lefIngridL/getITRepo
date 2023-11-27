namespace StudentAdmSys;

public class Grade
{
  public Student Student { get; set; }
  public Fag Fag { get; set; }
  public double GradeValue { get; set; }

 

  public Grade(Student student, Fag fag, double gradeValue)
  {
      Student = student;
      Fag = fag;
      GradeValue = gradeValue;

  }

 
  

  public void SkrivUtInfo()
  {
      Console.WriteLine($"Student: {Student.Name}\nFag: {Fag.FagNavn}\nKarakter: {GradeValue}");
  }
}


