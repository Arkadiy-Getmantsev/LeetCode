using System;

namespace Algorithms
{
    public static class ZigZagConversion6
    {
        public static string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s?.Trim())) return string.Empty;

            if (numRows == 1 || s.Length == 1 || s.Length <= numRows)
                return s;

            int columns = (int)((s.Length / (decimal)numRows) + 
                (Math.Ceiling(s.Length / (decimal)numRows) / 2));

            string[,] matrix = new string[numRows, columns];

            int indexString = 0;

            for (int i = 0; i < columns; i++)
            {
                if (i != 0) indexString--;

                for (int j = 0; j < numRows; j++)
                {
                    if (indexString > s.Length - 1)
                    {
                        continue;
                    }
                    else
                    {
                        matrix[j, i] = s[indexString].ToString();
                        ++indexString;
                    }
                }

                i++;

                if (i == columns) continue;

                indexString--;

                for (int j = numRows - 1; j >= 0; j--)
                {
                    if (indexString > s.Length - 1)
                    {
                        continue;
                    }
                    else
                    {
                        matrix[j, i] = s[indexString].ToString();
                        ++indexString;
                    }
                }
            }

            var result = string.Empty;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(i == 0)
                    {
                        if(j == 0 || j % 2 != 0)
                        {
                            result += matrix[i, j] ?? string.Empty;
                        }
                    }
                    else if(i == numRows - 1)
                    {
                        if (j % 2 != 0)
                        {
                            result += matrix[i, j] ?? string.Empty;
                        }
                    }
                    else
                    {
                        result += matrix[i, j] ?? string.Empty;
                    }
                }
            }

            return result;              
        }
    }
}
    