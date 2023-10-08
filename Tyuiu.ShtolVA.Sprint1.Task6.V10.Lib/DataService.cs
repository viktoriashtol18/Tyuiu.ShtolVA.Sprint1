using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShtolVA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string words)
        {
            string[] wordArr = words.Split(' ');
            int length = wordArr.Length;
            string[] modifiedWords = new string[length];

            for (int i = 0; i < length; i++)
            {
                string word = wordArr[i];
                int wordLength = word.Length;

                if (wordLength % 2 == 1)
                {
                    int middleIndex = wordLength / 2;
                    modifiedWords[i] = word.Remove(middleIndex, 1);
                }
                else
                {
                    modifiedWords[i] = word;
                }
            }

            return string.Join(" ", modifiedWords);
        }
    }
}
