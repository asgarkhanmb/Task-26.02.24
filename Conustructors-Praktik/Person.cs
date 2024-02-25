
namespace Conustructors_Praktik
{
    class Person
    {
        public int id;
        public string fullname;
        public int age;
        public string position;

        public Person(int id, string fullname, int age, string position)
        {
            this.id = id;
            this.fullname = fullname;
            this.age = age;
            this.position = position;
        }



        public Person() : this("Asgarkhan")
        {
            Console.WriteLine("Hello Behruz bey");
        }

        public Person(string data) : this(100)
        {
            Console.WriteLine(data);
        }

        public Person(int num)
        {
            Console.WriteLine("num");
        }

        public Person(string text, string s) : this(text)
        {
            Console.WriteLine(s);
        }



    }
}
