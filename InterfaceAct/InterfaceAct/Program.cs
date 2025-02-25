namespace InterfaceAct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>
        {
            new Admin { Fname = "Carl", Mname = "C.", Lname = "Interino", Birthdate = new DateTime(2004, 6, 2), EmailAddress = "carl.andre@admin.com" },
            new Student { Fname = "DellWhen", Mname = "B.", Lname = "Tan", Birthdate = new DateTime(1999, 8, 10), EmailAddress = "Dell.When@student.com" },
            new Employee { Fname = "Jordan", Mname = "A.", Lname = "Franzel", Birthdate = new DateTime(1999, 4, 5), EmailAddress = "MichaelJordan@employee.com" }
        };

            foreach (var person in people)
            {
                Console.WriteLine($"\n{person.GetType().Name}: {person.GetName()}, Birthday: {person.Birthdate.ToShortDateString()}, Email: {person.EmailAddress}");

                switch (person)
                {
                    case Admin admin:
                        admin.Create();
                        admin.Update();
                        admin.Delete();
                        break;
                    case Student student:
                        student.Study();
                        break;
                    case Employee employee:
                        employee.Teach();
                        employee.AdminWork();
                        break;
                }
            }
            }
    }
}
