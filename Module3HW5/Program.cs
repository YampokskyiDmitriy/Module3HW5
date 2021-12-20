using System;
using Module3HW5.Services;

namespace Module3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileService = new FileService();
            var result = fileService.ReadFilesAsync("Content/hello.txt", "Content/word.txt").GetAwaiter().GetResult();
            Console.WriteLine(result);
        }
    }
}