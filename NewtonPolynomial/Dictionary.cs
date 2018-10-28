using System;
using System.Collections.Generic;
using System.Linq;

namespace NewtonPolynomial
{
    internal class Dictionary
    {


        // *** NON-STATIC MEMBERS ***



        // Исходное слово
        private string slovo;
        // Cловарь
        private List<string> Words { get; set; }
        // Количество слов в словаре
        public int Count;





        // Введение данных
        public bool InputData(List<string> t, string s)
        {
            this.Words = t;
            this.slovo = s;

            return (Words.Count!=0);
        }
        //Поиск слов
        public void Run()
        {
            Count = 0;
            for (int i = 0; i < Words.Count; i++)
            {
                bool Flag = true;
                for (int j = 0; (Flag)&&(j < Words[i].Length); j++)
                {
                    char l = Words[i][j];
                    if (slovo.Contains(l))
                        Flag = true;
                    else
                        Flag = false;

                }
                if (Flag) Count++;
            }

        }
    }
}