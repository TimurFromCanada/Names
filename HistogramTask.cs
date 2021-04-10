using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var days = new string[31];

            for (var i = 0; i < days.Length; i++)
            {
                days[i] = (i + 1).ToString();
            }

            var countDates = new double[days.Length];

            foreach (var e in names)
            {
                if (e.Name == name && e.BirthDate.Day != 1)
                {
                    countDates[e.BirthDate.Day - 1]++;
                }
            }
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                days,
                countDates);
        }
    }
}