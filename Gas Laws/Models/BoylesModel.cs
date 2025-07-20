using System;
using System.Collections.Generic;

namespace Gas_Laws.Models
{
    public class BoylesModel
    {
        private int mtx_row = 2;
        private int mtx_col = 2;
        public string GetEx(Dictionary<int, double> values)
        {
            int Ex = 0;

            for (int i = 1; i < mtx_row + 1; i++)
            {
                for (int j = 1; j < mtx_col + 1; j++)
                {
                    if (values[i * 10 + j] == 0)
                    {
                        Ex = (i * 10 + j); break;
                    }
                }
            }

            switch (Ex)
            {
                case 11:
                    return Math.Round(((values[12] * values[22]) / values[21]), 5).ToString();

                case 12:
                    return Math.Round(((values[11] * values[21]) / values[22]), 5).ToString();

                case 21:
                    return Math.Round(((values[12] * values[22]) / values[11]), 5).ToString();

                case 22:
                    return Math.Round(((values[11] * values[21]) / values[12]), 5).ToString();
            }

            return "BoylesModel Error";
        }

    }
}
