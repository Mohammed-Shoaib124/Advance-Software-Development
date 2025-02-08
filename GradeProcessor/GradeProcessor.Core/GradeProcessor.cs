namespace GradeProcessor.Core
{
    public class GradeProcessor
    {
        public static double CalculateAverage(List<int> grade)
        {
            if (grade.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grade.Average();
        }

        public static double MaximumGrade(List<int> grade)
        {
            if (grade.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grade.Max();
        }

        public static double MedianGrade(List<int> grade)
        {
            if (grade.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            var sortedNumbers = grade.OrderBy(n => n).ToList();
            int count = sortedNumbers.Count;

            // Handle even and odd count
            if (count % 2 == 0)
            {
                return (sortedNumbers[count / 2 - 1] + sortedNumbers[count / 2]) / 2.0;
            }
            else
            {
                return sortedNumbers[count / 2];
            }
        }
    }
}
