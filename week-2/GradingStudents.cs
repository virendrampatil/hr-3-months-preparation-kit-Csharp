class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        var roundOffGrades = new List<int>();
        var roundOff = 0;

        for (int i = 0; i < grades.Count; i++)
        {
            roundOff = grades[i];
            if (roundOff > 37 && roundOff % 5 > 2 )
            {
                roundOff += 5 - roundOff % 5;
            }
            roundOffGrades.Add(roundOff);
        }
        return roundOffGrades;
    }
}