namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce yourself.");
            string myName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int myAge = Convert.ToInt32(Console.ReadLine());
            int birthday = 1;
            int newAge = myAge + birthday;
            char yes = 'Y';
            bool am_i_learning_to_code = true;
            decimal money = 2.05m;
            Console.WriteLine("How much money do you need?");
            double helpMe = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hello, {myName}. You are currently {myAge}, and you will be {newAge} on your Birthday!");
            Console.WriteLine($"Can you spare me a few bucks? I have ${money} to my name. I need ${helpMe}.");
            Console.WriteLine($"Are we having fun coding? {yes}es we are!");
        }
    }
}
