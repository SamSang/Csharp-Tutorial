using System;
using System.Collections.Generic;
using System.IO;

namespace TeleprompterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = ReadFrom("sampleQuotes.txt");
            foreach (var line in lines)
            {
                Console.Writeline(line)
            }
        }
        //comment?
        //IEnumerable is an interface defined in System.Collections.Generic
        //This is an Iterator method
        //They return sequences that are evaluated lazily -- But what does Lazy mean?
        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            //File is a class class is defined in System.IO 
            //var means you make a variable
            //reader is thus an Implicitly typed local variable. It's defined at compile time.
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
