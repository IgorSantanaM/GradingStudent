class Result
{
    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> roundedGrades = new List<int>();

        foreach (var grade in grades)
        {
            if (grade >= 38)
            {
                int remainder = grade % 5;
                if (remainder >= 3)
                {
                    roundedGrades.Add(grade + (5 - remainder));
                }
                else
                {
                    roundedGrades.Add(grade);
                }
            }
            else
            {
                roundedGrades.Add(grade);
            }
        }

        return roundedGrades;
    }
}