using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var days = new string[30];

            for (int i = 0; i < 30; i++)
            {
                days[i] = (i + 2).ToString();
            }

            var month = new string[12];

            for (int i = 0; i < 12; i++)
            {
                month[i] = (i + 1).ToString();
            }

            double[,] mounthDay = new double[30, 12];

            foreach (var e in names)
            {
                if (e.BirthDate.Day != 1)
                {
                    mounthDay[e.BirthDate.Day - 2, e.BirthDate.Month - 1]++;
                }
            }
                
            return new HeatmapData("Пример карты интенсивностей", mounthDay, days, month);
        }
    }
}

