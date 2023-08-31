using System.Globalization;


public interface IAliService
{
    List<string> GetOddMonths();
}

public class Ali: IAliService
{
    public List<string>GetOddMonths()
    { 
        List<string> oddMonths = new List<string>(); 
        for(int month = 1;month<=12;month+=2)
        {
            oddMonths.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month));
        }
        return oddMonths;
    }
}