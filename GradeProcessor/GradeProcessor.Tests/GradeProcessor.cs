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


    }
}
