namespace StudentAdmSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            some();
        }

        static void some()
        {
        Fag fag1 = new Fag("MN F IT 272", "Kunstig intelligens", 10);
        Fag fag2 = new Fag("MN F IT 213", "Objektorientert systemutvikling", 10);
        Fag fag3 = new Fag("MN F IT 167", "Databaseteknikk", 10);

        List<Grade> gradeList1 = new List<Grade>();
        List<Grade> gradeList2 = new List<Grade>();
        List<Fag> myFagList1 = new List<Fag>();
        List<Fag> myFagList2 = new List<Fag>();
            //fag1.SkrivUtInfo();
            //fag2.SkrivUtInfo();
            
        

        Student student1 = new Student("Ola Pedersen", 23, "DataIngeniør", 3028, myFagList1, gradeList1);
        Student student2 = new Student("Pernille Åsen", 19, "It-Utvikler", 1063, myFagList2, gradeList2);
        


        myFagList1.Add(fag1);
        myFagList1.Add(fag2);
        myFagList1.Add(fag3);
        myFagList2.Add(fag1);
        myFagList2.Add(fag2);
        myFagList2.Add(fag3);

        Grade grade1_1= new Grade(student1, fag1, 1.0);
        Grade grade1_2 = new Grade(student1, fag2, 2.1);
        Grade grade1_3 = new Grade(student1, fag3, 2.6);
        Grade grade2_1 = new Grade(student2, fag1, 2.8);
        Grade grade2_2 = new Grade(student2, fag2, 2.5);
        Grade grade2_3 = new Grade(student2, fag3, 2.0);

        //grade2.SkrivUtInfo();
        //grade1.SkrivUtInfo();
        //student1.SkrivUtInfo();
        //student2.SkrivUtInfo();


        gradeList1.Add(grade1_1);
        gradeList1.Add(grade1_2);
        gradeList1.Add(grade1_3);
        gradeList2.Add(grade2_1);
        gradeList2.Add(grade2_2);
        gradeList2.Add(grade2_3);

            

            //student1.SkrivUtInfo();
            //student2.SkrivUtInfo();

            student1.PrintSnitt();
            student2.PrintSnitt();
            student1.PrintSP();
            student2.PrintSP();
        }

    }
}