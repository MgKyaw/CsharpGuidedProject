﻿int examAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];

int[] studentScores = new int[10];

string currentStudentLetterGrade;

Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    currentStudentLetterGrade = GetLetterGrade(currentStudentGrade);

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

static string GetLetterGrade(decimal grade)
{
    string currentStudentLetterGrade;

    if (grade >= 97)
        currentStudentLetterGrade = "A+";

    else if (grade >= 93)
        currentStudentLetterGrade = "A";

    else if (grade >= 90)
        currentStudentLetterGrade = "A-";

    else if (grade >= 87)
        currentStudentLetterGrade = "B+";

    else if (grade >= 83)
        currentStudentLetterGrade = "B";

    else if (grade >= 80)
        currentStudentLetterGrade = "B-";

    else if (grade >= 77)
        currentStudentLetterGrade = "C+";

    else if (grade >= 73)
        currentStudentLetterGrade = "C";

    else if (grade >= 70)
        currentStudentLetterGrade = "C-";

    else if (grade >= 67)
        currentStudentLetterGrade = "D+";

    else if (grade >= 63)
        currentStudentLetterGrade = "D";

    else if (grade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    return currentStudentLetterGrade;
}