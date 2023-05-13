using System.Text.RegularExpressions;

namespace BetterRegex.Primitive;

public class SqlManager
{
    internal SqlManager()
    {
    }

    /// <summary>
    ///     Match a T-SQL statement that starts with SELECT, INSERT, UPDATE, DELETE, or EXECUTE
    /// </summary>
    /// <param name="tsql"></param>
    /// <returns></returns>
    public static bool IsValidTSql(string tsql)
    {
        string pattern = @"^(SELECT|INSERT|UPDATE|DELETE|EXECUTE)\s.+$";
        return Regex.IsMatch(tsql, pattern);
    }
}