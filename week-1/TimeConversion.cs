class Result
{
    public static string timeConversion(string s)
    {
        /*
        * DateTime.Parse(s).ToString("HH:mm:ss");
        * One line answer using datetime function     
        */

        var timeArray = s.Split(":").ToArray();
        var hours = Convert.ToInt32(timeArray[0]);
        var minutes = timeArray[1];
        var seconds = timeArray[2].Substring(0, 2);
        var timeOfDay = timeArray[2].Substring(2, 2);

        hours = timeOfDay == "AM" ?
                hours % 12 :
                (hours % 12) + 12;

        return $"{hours.ToString("D2")}:{minutes}:{seconds}";
    }
}