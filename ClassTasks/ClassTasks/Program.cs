namespace ClassTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Rashad", "Rufullayev", "AB104", 19);

            student.GetInfo();
            student.CheckGraduation();
            student.GetDiplomDegree();

        }

    }
    class Student
    {
        public string Name;

        public string Surname;

        public string Group;

        public byte Point;

        public bool isGraduated;

        public Student(string name, string surname, string group, byte point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

        }

        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Group} {Point} {isGraduated}");

        }
        public void CheckGraduation()
        {
            if (isGraduated)
            {
                Console.WriteLine("Telebe mezun ooldu");
            }
            else
            {
                Console.WriteLine("Telebe mezun olmadi ");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("Diplom ala bilmir");
            }
            else if (Point >= 65 && Point <= 80)
            {
                Console.WriteLine("Adi diplom");
            }
            else if (Point >= 80 && Point <= 90)
            {
                Console.WriteLine("Sheref diplomu");
            }
            else
            {
                Console.WriteLine("Yuksek sheref diplomu");
            }
        }

    }

}