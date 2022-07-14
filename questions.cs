class Questions
{
    string[] questions;

    public Questions(String fileName)
    {
        StreamReader sr = new StreamReader(fileName);
        string? questionList = sr.ReadToEnd();

        this.questions = questionList.Split(new string[] {"\n"}, StringSplitOptions.None);
    }

    public string getQuestion() {
        Random rnd = new Random();
        int index  = rnd.Next(0, questions.Length);
        return questions[index];
    }
}