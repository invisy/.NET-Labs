using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Lab8
{
    public class FileTask
    {
        private readonly string _fullFilePath;
        private readonly Semaphore _semaphore = new Semaphore(1, 2);

        public FileTask(string filePath)
        {
            _fullFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, filePath);
        }

        public void DoTask()
        {
            Thread thread1 = new Thread(WriteLineToFileAndOutputItToConsole);
            Thread thread2 = new Thread(WriteLineToFileAndOutputItToConsole);
            Thread thread3 = new Thread(WriteLineToFileAndOutputItToConsole);
            Thread thread4 = new Thread(WriteLineToFileAndOutputItToConsole);
            Thread thread5 = new Thread(WriteLineToFileAndOutputItToConsole);

            thread1.Start("Thread01");
            thread2.Start("Thread02");
            thread3.Start("Thread03");
            thread4.Start("Thread04");
            thread5.Start("Thread05");
        }


        private void WriteLineToFileAndOutputItToConsole(object lineToWrite)
        {
            _semaphore.WaitOne();

            WriteLineToFile(lineToWrite.ToString());
            Console.WriteLine(ReadFile());

            _semaphore.Release();
        }


        private void WriteLineToFile(string lineToWrite)
        {
            using (var sw = new StreamWriter(_fullFilePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(lineToWrite);
            }
        }

        private string ReadFile()
        {

            var fullFileText = "";
            using (var sr = new StreamReader(_fullFilePath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    fullFileText += line + '\n';
                }
            }

            return fullFileText;
        }
    }
}