using System;
using System.Collections.Generic;

namespace Morser
{
    public static class TextToMorse
    {
        public static string GenerateCodedData()
        {
            string text = GetTextData();
            List<bool> morseBits = StringToMorse(text);
            byte[] morseData = ConvertTextData(morseBits);
            string encryptedString = EncryptMorseData(morseData);

            return encryptedString;
        }    

        private static string GetTextData()
        {
            Console.WriteLine("Enter your message:");
            string text = Console.ReadLine();
            return text;
        }

        private static List<bool> StringToMorse(string text)
        {
            List<bool> morseData = new List<bool>();
            char[] characterList = text.ToCharArray();

            foreach (char character in characterList)
            {
                morseData.AddRange(CharToMorse(character));
            }

            return morseData;
        }

        private static List<bool> CharToMorse(char character)
        {
            if ((character < 'a' || character > 'z') &&
                (character < '0' || character > '9') &&
                (character < 'A' || character > 'Z') &&
                (character != '.') && (character != ',') &&
                (character != ' ') && (character != '?') &&
                (character != ';') && (character != ':') &&
                (character != '/') && (character != '-') &&
                (character != '\'') && (character != '_'))
                return new List<bool>();

            var morseCodeData = new List<bool>();

            switch (character)
            {
                case 'a':
                case 'A':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'b':
                case 'B':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'c':
                case 'C':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'd':
                case 'D':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'e':
                case 'E':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'f':
                case 'F':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'g':
                case 'G':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'h':
                case 'H':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'i':
                case 'I':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'j':
                case 'J':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'k':
                case 'K':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'l':
                case 'L':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'm':
                case 'M':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'n':
                case 'N':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'o':
                case 'O':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'p':
                case 'P':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'q':
                case 'Q':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'r':
                case 'R':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 's':
                case 'S':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 't':
                case 'T':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'u':
                case 'U':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'v':
                case 'V':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'w':
                case 'W':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'x':
                case 'X':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'y':
                case 'Y':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case 'z':
                case 'Z':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '0':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '1':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '2':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '3':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '4':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '5':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '6':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '7':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '8':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '9':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '.':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case ',':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '?':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case ';':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case ':':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '/':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case '-':
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                //case '\'':
                //    break;
                case '_':
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetDot());
                    morseCodeData.AddRange(GetDash());
                    morseCodeData.AddRange(GetLetterEnd());
                    break;
                case ' ':
                    morseCodeData.AddRange(GetSpace());
                    break;
                default:
                    break;
            }

            return morseCodeData;
        }

        private static byte[] ConvertTextData(List<bool> morseData)
        {
            byte[] byteData = new byte[(morseData.Count / 8 + 1)];

            int bitPosition = 7;
            int currentBytePosition = 0;

            foreach (bool bit in morseData)
            {
                if (bit)
                    byteData[currentBytePosition] += (byte)(1 << bitPosition);

                bitPosition--;

                if (bitPosition < 0)
                {
                    bitPosition = 7;
                    currentBytePosition++;

                    // Preventing index out of bounds error from occuring
                    if (currentBytePosition > byteData.Length - 1)
                        break;
                }
            }

            return byteData;
        }

        private static string EncryptMorseData(byte[] morseData)
        {
            // @TODO
            // Encrypt data using public key information

            string convertedData = Convert.ToBase64String(morseData);

            return convertedData;
        }

        private static List<bool> GetDot()
        {
            var morseDot = new List<bool>(2) {true, false};

            return morseDot;
        }

        private static List<bool> GetDash()
        {
            var morseDash = new List<bool>(2) {false, true};

            return morseDash;
        }

        private static List<bool> GetLetterEnd()
        {
            var morseLetterEnd = new List<bool>(2) {true, true};

            return morseLetterEnd;
        }

        private static List<bool> GetSpace()
        {
            var getSpace = new List<bool>(2) {false, false};

            return getSpace;
        }
    }
}
