namespace GA_FieldsProperties_MatthewVargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Input name for testing: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input invalid");
            }
            else
            {
                person.Name = input;
                Console.WriteLine($"Name: {person.Name}");


                Console.WriteLine($"Name: {person.ReadOnlyName}");

            }
        }
    }
}
