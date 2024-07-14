class Solution
{
    public static void Main(string[] args)
    {
        // Example input for testing
        List<int> grades = new List<int> { 73, 67, 38, 33 };

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine("Original grades: " + String.Join(", ", grades));
        Console.WriteLine("Rounded grades: " + String.Join(", ", result));
    }
}