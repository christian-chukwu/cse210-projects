using System;

class Program
{
    static void Main(string[] args)
    {
        // General assignment with a new student and topic
        Assignment assignment1 = new Assignment("Christian Chukwu", "Cell Biology");
        Console.WriteLine(assignment1.GetSummary());

        // Math assignment with new student, topic, section, and problems
        MathAssignment math1 = new MathAssignment("Amina Diallo", "Algebraic Expressions", "5.2", "12–24");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        // Writing assignment with new student, subject, and topic
        WritingAssignment writing1 = new WritingAssignment("Jean-Marc Kouassi", "African History", "The Rise of the Ashanti Empire");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}
