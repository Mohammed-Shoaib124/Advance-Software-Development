List<int> values = [70,80, 50,90, 40];
Console.WriteLine($"THe Grades are {string.Join(", ", values)}");
Console.WriteLine($"The Average of the grades is {GradeProcessor.Core.GradeProcessor.CalculateAverage(values)}");
Console.WriteLine($"The Maximum of the grades is {GradeProcessor.Core.GradeProcessor.MaximumGrade(values)}");
Console.WriteLine($"The Median of the grades is {GradeProcessor.Core.GradeProcessor.MedianGrade(values)}");

