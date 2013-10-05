using System;

namespace Morser
{
    public static class MorseToText
    {
        public static string ReadCodedData (string convertedString)
        {
            // @TODO
            // Create method to retrieve coded string data from somewhere (web or hard drive?)

            byte[] morseBits = DescryptMorseData(convertedString);
            string morseString = ConvertToMorseString(morseBits);
            string finalText = ConvertToText(ref morseString);

            return finalText;
        }

        private static string ConvertToText(ref string morseString)
        {
            string finalText = "";

            int pos = 0;

            while (pos < morseString.Length)
            {
                if (morseString.Substring(pos, 2).Equals(CharacterMorseData.SPACE))
                {
                    finalText += " ";
                    morseString = morseString.Substring(pos + 2);
                    pos = 0;
                }
                else if (morseString.Substring(pos, 2).Equals(CharacterMorseData.LETTER_END))
                {
                    finalText += MorseToText.MorseToChar(morseString.Substring(0, pos + 2));
                    morseString = morseString.Substring(pos + 2);
                    pos = 0;
                }
                else
                    pos += 2;
            }
            return finalText;
        }

        private static string ConvertToMorseString(byte[] originalData)
        {
            bool[] convertedData = new bool[originalData.Length * 8];
            int morsePosition = 0;

            foreach (byte dataBlock in originalData)
            {
                int i = 0;

                for (i = 0; i < 8; i++)
                {
                    if ((dataBlock & (1 << (7 - i))) > 0)
                    {
                        convertedData[morsePosition] = true;
                    }
                    else
                    {
                        convertedData[morsePosition] = false;
                    }

                    morsePosition++;
                }
            }

            string morseString = "";

            foreach (bool j in convertedData)
            {
                if (j)
                    morseString += "1";
                else
                    morseString += "0";
            }
            return morseString;
        }

        private static byte[] DescryptMorseData(string convertedString)
        {
            byte[] originalData = Convert.FromBase64String(convertedString);
            return originalData;
        }

        private static string MorseToChar(string morseString)
        {
            switch (morseString)
            {
                case CharacterMorseData.CHAR_NUM_ZERO:
                    return "0";
                case CharacterMorseData.CHAR_NUM_ONE:
                    return "1";
                case CharacterMorseData.CHAR_NUM_TWO:
                    return "2";
                case CharacterMorseData.CHAR_NUM_THREE:
                    return "3";
                case CharacterMorseData.CHAR_NUM_FOUR:
                    return "4";
                case CharacterMorseData.CHAR_NUM_FIVE:
                    return "5";
                case CharacterMorseData.CHAR_NUM_SIX:
                    return "6";
                case CharacterMorseData.CHAR_NUM_SEVEN:
                    return "7";
                case CharacterMorseData.CHAR_NUM_EIGHT:
                    return "8";
                case CharacterMorseData.CHAR_NUM_NINE:
                    return "9";
                case CharacterMorseData.CHAR_A:
                    return "a";
                case CharacterMorseData.CHAR_B:
                    return "b";
                case CharacterMorseData.CHAR_C:
                    return "c";
                case CharacterMorseData.CHAR_D:
                    return "d";
                case CharacterMorseData.CHAR_E:
                    return "e";
                case CharacterMorseData.CHAR_F:
                    return "f";
                case CharacterMorseData.CHAR_G:
                    return "g";
                case CharacterMorseData.CHAR_H:
                    return "h";
                case CharacterMorseData.CHAR_I:
                    return "i";
                case CharacterMorseData.CHAR_J:
                    return "j";
                case CharacterMorseData.CHAR_K:
                    return "k";
                case CharacterMorseData.CHAR_L:
                    return "l";
                case CharacterMorseData.CHAR_M:
                    return "m";
                case CharacterMorseData.CHAR_N:
                    return "n";
                case CharacterMorseData.CHAR_O:
                    return "o";
                case CharacterMorseData.CHAR_P:
                    return "p";
                case CharacterMorseData.CHAR_Q:
                    return "q";
                case CharacterMorseData.CHAR_R:
                    return "r";
                case CharacterMorseData.CHAR_S:
                    return "s";
                case CharacterMorseData.CHAR_T:
                    return "t";
                case CharacterMorseData.CHAR_U:
                    return "u";
                case CharacterMorseData.CHAR_V:
                    return "v";
                case CharacterMorseData.CHAR_W:
                    return "w";
                case CharacterMorseData.CHAR_X:
                    return "x";
                case CharacterMorseData.CHAR_Y:
                    return "y";
                case CharacterMorseData.CHAR_Z:
                    return "z";
                case CharacterMorseData.CHAR_COMMA:
                    return ",";
                case CharacterMorseData.CHAR_PERIOD:
                    return ".";
                case CharacterMorseData.CHAR_QUESTION:
                    return "?";
                case CharacterMorseData.CHAR_SEMICOLON:
                    return ";";
                case CharacterMorseData.CHAR_COLON:
                    return ":";
                case CharacterMorseData.CHAR_SLASH:
                    return "\\";
                case CharacterMorseData.CHAR_DASH:
                    return "-";
                case CharacterMorseData.CHAR_APOSTROPHE:
                    return "'";
//                case CharacterMorseData.CharParenthesis:
                case CharacterMorseData.CHAR_UNDERSCORE:
                    return "_";
                default:
                    return "";
            }
        }
    }
}
