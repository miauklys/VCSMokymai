using System;

namespace TaskSix
{
    class Program
    {
        const string contentDirectory = @"test.txt";
        static void Main(string[] args)
        {
            IFileAggregator fileAggregator = new FileAggregator(); 
            var content = fileAggregator.IsContent(contentDirectory);
            Console.WriteLine(content);

            fileAggregator.WriteToFile(content, contentDirectory);

            Console.WriteLine(@$"
            Naujas failo turinys yra šis:
            {fileAggregator.ReadText(contentDirectory)}");

            Console.WriteLine(@$"
            Klaidų turinys yra šis:
            {fileAggregator.ReadText(FileAggregator.ErrorFile)}");
        }
    }
}
