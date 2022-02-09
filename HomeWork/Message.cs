using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMessage
{
    internal class Message
    {
        #region Поля
        private StringBuilder msg;
        #endregion


        #region Конструкторы
        public Message(string str)
        {
            msg = new StringBuilder(str);
        }
        #endregion


        #region Свойства
        public string String
        {
            get
            {
                return msg.ToString();
            }
        }
        #endregion


        #region Скрытые методы

        #endregion


        #region Методы
        /// <summary>
        /// Печать слов с кол-ом букв меньше заданного
        /// </summary>
        /// <param name="numLetters">Кол-во букв в слове</param>
        public void PrintWordsWithLessLetters(int numLetters)
        {
            char[] separators = {' ', '.', ',', ':', ';', '!', '?'};
            string str = msg.ToString();
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= numLetters)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

        /// <summary>
        /// Удалить слова из строки оканчивающиеся на заданный символ
        /// </summary>
        /// <param name="ch">Символ</param>
        /// <returns>Получивщаяся строка</returns>
        public string RemoveWordsEndsTo(char ch)
        {
            char[] separators = { ' ', '.', ',', ':', ';', '!', '?' };
            string str = msg.ToString();
            StringBuilder outMsg = new StringBuilder(str);

            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length - 1] == ch)
                {
                    outMsg.Replace(" " + words[i], "");
                }
            }

            return outMsg.ToString();
        }

        /// <summary>
        /// Получить самые длинные слова
        /// </summary>
        /// <returns>Коллекция слов</returns>
        public Dictionary<int, string> GetLongWords()
        {
            Dictionary<int, string> LongWords = new Dictionary<int, string>();
            int wordLen = 0;
            int idx = 0;

            char[] separators = { ' ', '.', ',', ':', ';', '!', '?' };
            string str = msg.ToString();

            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > wordLen)
                {
                    idx = 0;
                    wordLen = words[i].Length;
                    LongWords.Clear();
                    LongWords.Add(idx, words[i]);
                }
                else if(words[i].Length == wordLen)
                {
                    idx++;
                    LongWords.Add(idx, words[i]);
                }
            }

            return LongWords;
        }

        /// <summary>
        /// Формирование строки из самых длиных слов 
        /// </summary>
        /// <returns>строка</returns>
        public string GetStringFromLongWords()
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<int, string> dict = GetLongWords();

            foreach (KeyValuePair<int, string> i in dict)
            {
                sb.Append(i.Value);

                if (i.Key != (dict.Count - 1))
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetStatistics(string str, string[] words)
        {
            char[] separators = { ' ', '.', ',', ':', ';', '!', '?' };
            string[] strWords = str.Split(separators, StringSplitOptions.None);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int counter;

            for (int i = 0; i < words.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < strWords.Length; j++)
                {
                    if (strWords[j].Equals(words[i]))
                    {
                        counter++;
                    }
                }

                if (counter > 0)
                {
                    dict.Add(key: words[i], value: counter);
                }
            }

            return dict;
        }
        #endregion
    }
}
