using System.Runtime.CompilerServices;

namespace StudentAdmSys;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string AcademicPath { get; set; }
    public int StudentId { get; set; }

    public Student(string name, int age, string academicPath, int studentId, List<Fag> fagliste, List<Grade> gradelist)
    {
        Name = name;
        Age = age;
        AcademicPath = academicPath;
        StudentId = studentId;
        FagListe = fagliste;
        GradeList = gradelist;
    }

    public List<Fag> FagListe { get; set; }
    public List<Grade> GradeList { get; set; }
    public void SkrivUtInfo()
    {
        Console.WriteLine($"Navn: {Name}\nAlder: {Age}\nStudieretning: {AcademicPath}\nStudentId: {StudentId}\nFag liste: ");
        foreach (var fag in GradeList)
        {
            Console.WriteLine($"{fag.Fag.FagNavn}: {fag.GradeValue}");
            
            
            

        }
        
    }

    public void PrintSnitt()
    {
        Console.WriteLine($"Student {Name} sitt karaktersnitt er");
        double gradesum = 0;
        int gradecount = 0;
        foreach (var grade in GradeList)
        {
            double gradeval = grade.GradeValue;
            gradesum += gradeval;
            gradecount++;
        }
        double gradeMean = gradesum / gradecount;
        char LetterGrade;
        if (gradeMean >= 1.0 && gradeMean <= 2.0)
        {
            LetterGrade = 'A';

            Console.WriteLine($"{LetterGrade} ({Math.Round(gradeMean, 2)})");
        }
        else if (gradeMean >= 2.1 && gradeMean <= 2.5)
        {
            LetterGrade = 'B';
            Console.WriteLine($"{LetterGrade} ({Math.Round(gradeMean, 2)})");
        }
        else if (gradeMean >= 2.6 && gradeMean <= 2.8)
        {
            LetterGrade = 'C';
            Console.WriteLine($"{LetterGrade} ({Math.Round(gradeMean, 2)})");
        }
        else if (gradeMean >= 2.9 && gradeMean <= 3.2)
        {
            LetterGrade = 'D';
            Console.WriteLine($"{LetterGrade} ({Math.Round(gradeMean, 2)})");
        }
        else if (gradeMean >= 3.3 && gradeMean <= 4.0)
        {
            LetterGrade = 'E';
            Console.WriteLine($"{LetterGrade} ({Math.Round(gradeMean, 2)})");
        }

        
    }

    public void PrintSP()
    {
        int SPsum = 0;
        foreach (var fag in FagListe)
        {
            int SP = fag.AntallStudiepoeng;
            SPsum += SP;
        }

        Console.WriteLine(SPsum);
    }
}

//A - 1.0-2.0
//B - 2.1-2.5
//C - 2.6-2.8
//D - 2.9-3.2
//E - 3.3-4.0
//A: 5 poeng
//B: 4 poeng
//C: 3 poeng
//D: 2 poeng
//E: 1 poeng