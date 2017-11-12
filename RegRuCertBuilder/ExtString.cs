using System;

namespace RegRuCertBuilder
{
    public static class ExtString
    {
        /// <summary>
        /// Вырезает одну строку между двумя подстроками.
        /// </summary>
        /// <param name="str">Строка где следует искать подстроки</param>
        /// <param name="left">Начальная подстрока</param>
        /// <param name="right">Конечная подстрока</param>
        /// <param name="startIndex">Искать начиная с индекса</param>
        /// <param name="comparsion">Метод сравнения строк</param>
        /// <returns>Возвращает строку между двумя подстроками</returns>
        public static string Substring(this string str, string left, string right,
            int startIndex = 0, StringComparison comparsion = StringComparison.Ordinal)
        {
            if (!string.IsNullOrEmpty(str) &&
                !string.IsNullOrEmpty(left) &&
                !string.IsNullOrEmpty(right) &&
                startIndex >= 0 && startIndex < str.Length)
            {

                // Ищем начало позиции левой подстроки.
                int leftPosBegin = str.IndexOf(left, startIndex, comparsion);
                if (leftPosBegin != -1)
                {
                    // Вычисляем конец позиции левой подстроки.
                    int leftPosEnd = leftPosBegin + left.Length;
                    // Ищем начало позиции правой строки.
                    int rightPos = str.IndexOf(right, leftPosEnd, comparsion);

                    if (rightPos != -1)
                        return str.Substring(leftPosEnd, rightPos + right.Length - leftPosEnd);
                }
            }

            throw new FormatException($"Не найдена подстрока: \"${left}\", \"${right}\"");
        }  
    }
}