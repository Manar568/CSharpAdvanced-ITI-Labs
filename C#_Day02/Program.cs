namespace C__Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.Age = 3;
            lion.Name = "Lion1";

            Sparrow sparrow = new Sparrow();
            sparrow.Age = 5;
            sparrow.Name = "Sparrow1";


            //Cage<Lion> cage = new Cage<Sparrow>();
            Cage<Lion> cage= new Cage<Lion>();
            cage.Arrive(lion);
            cage.list[0].Roar();
            //cage.Arrive(sparrow);


            Lion l = new Lion();
            l.Age = 10;
            l.Name = "L";

            try
            {
                cage.Arrive(l);
            }
            catch (InvalidAgeException ex) {

                Console.WriteLine(ex.Message);

            }
            

            Student student = new Student();
            student.Name = "Manar";
            student.AddGrade(90);
            student.AddGrade(80);
            student.AddGrade(60);
            Console.WriteLine(student.Average());

            Student student2 = new Student();
            student2.Name = "Nada";
            student2.AddGrade(70);
            student2.AddGrade(50);
            student2.AddGrade(60);

            List<Student> studentList = new List<Student>();
            studentList.Add(student);
            studentList.Add(student2);
            int highAvg = 0;
            string name = "";
            foreach(var item in studentList)
            {
                if(item.Average()>highAvg)
                {
                    highAvg = item.Average();
                    name = item.Name;

                }

            }
            Console.WriteLine($"the hight avg is {highAvg} for student {name}");



            //student.Grades.Add(90);
            //student.Grades.Add(95);
            //student.Grades.Add(80);

            // Dictionary<string s, List<int>> studentGrades =new Dictionary<student.Name, student.Grades>();



            Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>();
            studentGrades.Add(student.Name, student.Grades);
            studentGrades.Add(student2.Name, student2.Grades);


            foreach (var item in studentGrades)
            {
                Console.WriteLine($" Name :{item.Key}");

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"Grade :{item2}");
                }
            }

            Console.WriteLine(student.Average());



            ToDoList toDoList = new ToDoList();
            toDoList.NewTask("task1");
            toDoList.NewTask("task2");
            toDoList.NewTask("task3");
            toDoList.NewTask("task4");
            toDoList.AllTasks();
            toDoList.CompletedTask();





            PhonNumbers phonNumbers = new PhonNumbers();
            phonNumbers.AddContact("manar", 4521);

            phonNumbers.AddContact("Sahar", 3321);

            Console.WriteLine(phonNumbers.Search("Sahar"));

            try
            {
                phonNumbers.Search("Ahmed");
            }
            catch(ContactNotFoundExcption ex)
            {
                Console.WriteLine(ex.Message);

            }




            BrowserHistory history = new BrowserHistory();
            history.VisitedPage("google.com");
            history.VisitedPage("amazon.com");
            history.ExitPage();
            history.AllPages();
            





        }
    }
}
