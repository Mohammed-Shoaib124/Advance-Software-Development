namespace GradeProcessor.Tests
{
    public class GradeProcessorTests
    {
        [Fact]
        public void CalculateAverage_ShouldReturnCorrectAverage()
        {
            List<int> grades = new List<int> { 80, 90, 100 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateAverage(grades);
            Assert.Equal(90.0, result, 1);
        }

        [Fact]
        public void CalculateAverage_ShouldHandleEmptyList()
        {
            List<int> grades = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeProcessor.CalculateAverage(grades));
        }

        [Fact]
        public void CalculateAverage_ShouldHandle100MGradesIn1Sec()
        {
            List<int> grades = Enumerable.Range(1, 100_000_000).ToList();
            DateTime start = DateTime.UtcNow;
            GradeProcessor.Core.GradeProcessor.CalculateAverage(grades);
            DateTime end = DateTime.UtcNow;
            double elapsed = (end - start).TotalMilliseconds;
            Assert.True(elapsed < 200, $"Execution took {elapsed} ms");
        }

        [Fact]
        public void MaximumGrade_ShouldReturnCorrectMaximum()
        {
            List<int> grades = new List<int> { 70, 80, 90, 50, 40 };
            double result = GradeProcessor.Core.GradeProcessor.MaximumGrade(grades);
            Assert.Equal(90, result);
        }

        [Fact]
        public void MaximumGrade_EmptyList_ShouldThrowArgumentException()
        {
            List<int> grades = new List<int>();

            var exception = Assert.Throws<ArgumentException>(() => GradeProcessor.Core.GradeProcessor.MaximumGrade(grades));
            Assert.Equal("Empty List", exception.Message);
        }

        [Fact]
        public void MaximumGrade_ShouldHandle100MGradesIn1Sec()
        {
            List<int> grades = Enumerable.Range(1, 100_000_000).ToList();
            DateTime start = DateTime.UtcNow;
            GradeProcessor.Core.GradeProcessor.MaximumGrade(grades);
            DateTime end = DateTime.UtcNow;
            double elapsed = (end - start).TotalMilliseconds;
            Assert.True(elapsed < 200, $"Execution took {elapsed} ms");
        }

        [Fact]
        public void MedianGrade_ShouldReturnCorrectMedian_ForOddCount()
        {
            List<int> grades = new List<int> { 70, 80, 90, 50, 40 };
            double result = GradeProcessor.Core.GradeProcessor.MedianGrade(grades);
            Assert.Equal(70, result);
        }

        [Fact]
        public void MedianGrade_ShouldReturnCorrectMedian_ForEvenCount()
        {
            List<int> grades = new List<int> { 10, 20, 30, 40 };
            double result = GradeProcessor.Core.GradeProcessor.MedianGrade(grades);
            Assert.Equal(25.0, result, 1);
        }

        [Fact]
        public void MedianGrade_EmptyList_ShouldThrowArgumentException()
        {
            List<int> grades = new List<int>();

            var exception = Assert.Throws<ArgumentException>(() => GradeProcessor.Core.GradeProcessor.MedianGrade(grades));
            Assert.Equal("Empty List", exception.Message);
        }

    }
}
