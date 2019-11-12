using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace MusicAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = LoadFile(args[0]);
            string outputFileName = args[1];


        }

        public static List<Song> LoadFile(string fileName)
        {
            List<Song> songs = new List<Song>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    int lineCount = 0;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split('\t');
                        lineCount++;

                        if (parts.Length != 7) throw new InvalidNumberOfValuesException(lineCount, parts.Length, 7);

                        int size = -1;
                        Int32.TryParse(parts[4], out size);
                        if (size == -1) throw new InvalidTypeException(lineCount, 5, typeof(int));

                        int time = -1;
                        Int32.TryParse(parts[5], out time);
                        if (time == -1) throw new InvalidTypeException(lineCount, 6, typeof(int));

                        int year = -1;
                        Int32.TryParse(parts[6], out year);
                        if (year == -1) throw new InvalidTypeException(lineCount, 7, typeof(int));


                        Song song = new Song(parts[0],
                                             parts[1],
                                             parts[2],
                                             parts[3],
                                             Int32.Parse(parts[4]),
                                             Int32.Parse(parts[5]),
                                             Int32.Parse(parts[6]));

                        songs.Add(song);
                    }
                }
            }
            catch(IOException)
            {
                WriteLine($"Error reading {fileName}: Cannot open file.");
            }
            catch(Exception e)
            {
                WriteLine($"Error reading {fileName}: {e.Message}");
            }

            return songs;
        }
    }
}
