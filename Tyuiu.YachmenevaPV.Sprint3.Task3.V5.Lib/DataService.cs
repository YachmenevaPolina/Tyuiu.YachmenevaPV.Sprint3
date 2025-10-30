using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YachmenevaPV.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            foreach (char a in value)
            {
                if (a == replaceable)
                {
                    value = value.Replace(a, replacement);
                }
            }
            return value;
        }
    }
}
