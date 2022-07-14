namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Questions generic = new Questions("./questions/generic.txt");
            Questions achievements = new Questions("./questions/achievement.txt");
            Questions expectations = new Questions("./questions/expectations.txt");
            Questions thinkers = new Questions("./questions/thinkers.txt");
            Questions response = new Questions("./questions/response.txt");

            List<string?> questionAnswerList = new List<string?>();
            String question = "";

            question = generic.getQuestion();
            Console.WriteLine(question);
            questionAnswerList.Add(question);
            questionAnswerList.Add(Console.ReadLine());
            Console.WriteLine(response.getQuestion());
            Console.WriteLine();

            question = generic.getQuestion();
            Console.WriteLine(question);
            questionAnswerList.Add(question);
            questionAnswerList.Add(Console.ReadLine());
            Console.WriteLine(response.getQuestion());
            Console.WriteLine();

            question = achievements.getQuestion();
            Console.WriteLine(question);
            questionAnswerList.Add(question);
            questionAnswerList.Add(Console.ReadLine());
            Console.WriteLine(response.getQuestion());
            Console.WriteLine();

            question = expectations.getQuestion();
            Console.WriteLine(question);
            questionAnswerList.Add(question);
            questionAnswerList.Add(Console.ReadLine());
            Console.WriteLine(response.getQuestion());
            Console.WriteLine();

            question = thinkers.getQuestion();
            Console.WriteLine(question);
            questionAnswerList.Add(question);
            questionAnswerList.Add(Console.ReadLine());
            Console.WriteLine(response.getQuestion());
            Console.WriteLine();

            Console.WriteLine("Thank you for interviewing with us! I hope to be in contact with you soon!");

            Answers answers = new Answers("./results/results.txt", questionAnswerList);
            answers.writeToFile();
        }
    }
}