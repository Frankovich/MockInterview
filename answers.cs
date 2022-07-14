class Answers
{
    string filename;
    List<string?> results;

    public Answers(String fileNameToWrite, List<string?> results)
    {
        this.filename = fileNameToWrite;
        this.results = results;
    }

    public void writeToFile()
    {
        File.WriteAllText(filename, "");
        for (int i = 0; i < results.Count; i++)
        {
            File.AppendAllText(filename, results[i]);
            File.AppendAllText(filename, "\n\n");
        }
    }
}