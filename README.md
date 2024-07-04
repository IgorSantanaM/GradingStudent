# Grading Students

A C# program to adjust student grades based on rounding rules.

## Problem Description

The function `gradingStudents` modifies student grades based on these rules:
- Grades below 38 remain unchanged.
- Grades 38 and above are rounded up to the nearest multiple of 5 if the difference is less than 3.

### Example

Input: `[73, 67, 38, 33]`  
Output: `[75, 67, 40, 33]`

## Getting Started

Follow these instructions to set up and run the project locally.

### Prerequisites

- .NET SDK or a C# compiler

### Installation

1. **Clone the repository**:
    ```bash
    git clone <repository-url>
    cd grading-students
    ```

2. **Compile and run**:
    - **Using .NET CLI**:
      ```bash
      dotnet build
      dotnet run
      ```
    - **Using C# compiler**:
      ```bash
      csc Program.cs -out:gradingstudents.exe
      ./gradingstudents.exe
      ```

## Code

### Program.cs

```csharp
using System;
using System.Collections.Generic;
using System.IO;

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
```
## Usage
Modify the grades list in Solution.Main to test different sets of grades.

`Example`
For the following input:
``` csharp
List<int> grades = new List<int> { 73, 67, 38, 33 };
```

## Example Test Cases

| Input              | Expected Output    |
|--------------------|---------------------|
| `[73, 67, 38, 33]` | `[75, 67, 40, 33]`  |
| `[84, 29, 57, 90]` | `[85, 29, 57, 90]`  |
