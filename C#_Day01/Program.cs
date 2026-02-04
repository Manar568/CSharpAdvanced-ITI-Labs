namespace C__Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Console.WriteLine("1111111111111111111111111111111111111111111111111");


            PhoneBook phoneBook = new PhoneBook();

            phoneBook["mmm"]=4785;
            Console.WriteLine(phoneBook["mmm"]);

            phoneBook[3333] = "nada";



            Console.WriteLine(phoneBook["nada"]);
            Console.WriteLine(phoneBook[3333]);


            //phoneBook["manar"] = 5472;
            //Console.WriteLine(phoneBook["manar"]);

            //phoneBook["manar"] = 0;
            //Console.WriteLine(phoneBook["manar"]);





            //  Console.WriteLine("222222222222222222222222222222222222222222222222");




            Person p = new Person();
            p.FName = "manar";
            p.LName = "AbdelHak";
            Console.WriteLine(p.FullName);
            p.Age = 10;
            p.Password = "password";



         //   Console.WriteLine("3333333333333333333333333333333333333333333333333333333333333333333");


            Circle circle = new Circle();
            circle.Radius = 5;
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine( circle.GetColor());




            Rectangle rectangle= new Rectangle();
            rectangle.Height = 5;
            rectangle.Width = 10;

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.GetColor());












        }
    }
}
