using System.Linq.Expressions;

namespace ExceptionHandling
{
    class invalidNameException : Exception {
        public invalidNameException(string message) : base(message)
        {

        }
    }
    class Biometrics
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Biometrics n = new Biometrics();
            try
            {
                n.Name = "Jhone Doe";
                n.Id = "123456789";
                if(n.Name != "Bhavishya" || n.Name!="yash")throw new invalidNameException("Invalid name provided");
            }
            catch (invalidNameException i) {
                Console.WriteLine(i);
            }
        }
    }
}
