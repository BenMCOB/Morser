using System;
using System.Collections.Generic;

namespace Morser
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<bool> _binaryData = new List<bool>(0);
            
            const int byteChunkSize = 1024*160;

            // Get morse code data
            string encryptedString = TextToMorse.GenerateCodedData();

            // Convert back from Morse data
            string finalText = MorseToText.ReadCodedData(encryptedString);
            
            Console.WriteLine("Final texttt: {0}", finalText);

            Console.ReadLine();
        }
    }
}
