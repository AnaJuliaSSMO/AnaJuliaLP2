using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CodigoMorse
{
    class Morse
    {
        public string Frase { get; set; }
        public string Frase2 { get; set; }
        Dictionary<char, String> morsinha = new Dictionary<char, String>()
            {
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
                {' ',"    "}
            };

        Dictionary<String, char> morsinhanha = new Dictionary<String, char>()
            {
                {".-",'A'},
                {"-...",'B'},
                {"-.-.",'C'},
                {"-..",'D'},
                {".",'E'},
                { "..-.",'F'},
                {"--.",'G'},
                {"....",'H'},
                {"..",'I'},
                {".---",'J'},
                {"-.-",'K'},
                {".-..",'L'},
                {"--",'M'},
                {"-.",'N'},
                {"---",'O'},
                {".--.",'P'},
                {"--.-",'Q'},
                {".-.",'R'},
                {"...",'S'},
                {"-",'T'},
                {"..-",'U'},
                {"...-",'V'},
                {".--",'W'},
                {"-..-",'X'},
                {"-.--",'Y'},
                {"--..",'Z'},
                {"-----",'0'},
                {".----",'1'},
                {"..---",'2'},
                {"...--",'3'},
                {"....-",'4'},
                {".....",'5'},
                {"-....",'6'},
                {"--...",'7'},
                {"---..",'8'},
                {"----.",'9'},
                {" ", '|'}
            };

        public void Codificar(string frase)
        {
            this.Frase = frase;

            frase = frase.ToUpper();
            for (int x = 0; x < frase.Length; x++)
            {
                char i = frase[x];
                if (morsinha.ContainsKey(i))
                {
                    Console.Write(morsinha[i]);
                }
            }
        }

         public string Decodificar(string frase2)
        {
            this.Frase2 = frase2;
            frase2 = frase2.ToUpper();

            string[] separa = frase2.Split('|');

            for (int y = 0; y < separa.Length; y++)
            {
                string i = frase2;
                if (morsinhanha.ContainsKey(i))
                {
                    Console.Write(morsinhanha[i]);
                }
            }
            return String.Format(""); 
        } 
    }
}
