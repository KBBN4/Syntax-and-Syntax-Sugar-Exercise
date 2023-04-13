namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // inferred typing
            var answer = 4;
            string  response; //int.Parse(Console.ReadLine()); // unable to initiate without defining var response 



            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "is greater than or equal to nine";
            }

            Console.WriteLine(response);

            /*
            // string interpolation


            Console.WriteLine($" Hi , your {answer} is less than my {response}. Try again.");

            // ternary operator


            var message = (response < answer) ? " your answer is less than mine" : "try again";
            Console.WriteLine(message);
            */


        }
         

           
       

    }
}
