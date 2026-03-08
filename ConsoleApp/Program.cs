
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Babu");
            string msg = "Shreeram Singraul";
            string firstName = "Shreeram";
            string lastName = "Singraul";
            string name = $"My name is : {firstName} {lastName}";
            Console.WriteLine(name);
            Console.WriteLine(msg.Length);

            // Number Addition 

             Console.Write("Enter First Number : ");
            int firstNum =  Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Second Number : ");
            int SecNum =  Convert.ToInt32(Console.ReadLine());

            int addition = firstNum + SecNum ;
            int subtraction = firstNum - SecNum;
            int multiplication = firstNum * SecNum;
            int devide = firstNum / SecNum;


            Console.WriteLine("Addition is : " + "" + addition);
            Console.WriteLine(" Subtraction is  : " + "" + subtraction);
            Console.WriteLine(" Multiplication is  : " + "" + multiplication);
            Console.WriteLine(" Devide is  : " + "" + devide);

        }
    }
}