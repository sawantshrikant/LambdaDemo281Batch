namespace LambdaDemo281Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Lambda Demo Problem!");

            List<Person> list = new List<Person>()
            {
                new Person() {SSN =1,Name="Shrikant", Address="abc1", Age=25},
                new Person() {SSN =2,Name="Ram", Address="DEF2", Age=30},
                new Person() {SSN =3,Name="Sham", Address="ghi3", Age=35},
                new Person() {SSN =4,Name="Sammer", Address="ghi3", Age=45},
                new Person() {SSN =5,Name="Sagar", Address="poi3", Age=65},
                new Person() {SSN =6,Name="Komal", Address="poi3", Age=18},
                new Person() {SSN =7,Name="om", Address="poi3", Age=63},


            };
            DisplayPersonData(list);
        }

        public static void DisplayPersonData(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }

       
    }
}