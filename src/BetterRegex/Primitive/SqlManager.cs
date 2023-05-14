using System.Text.RegularExpressions;

namespace BetterRegex.Primitive;

public class SqlManager
{
    private static readonly Lazy<SqlManager> LazyInstance =
            new(() => new SqlManager(), LazyThreadSafetyMode.ExecutionAndPublication);

    private SqlManager()
    {
    }

    /// <summary>
    ///     Splits a SQL query by the "GO" command and returns an array of individual queries.
    /// </summary>
    /// <param name="sqlQuery">The SQL query to split.</param>
    /// <returns>An array of individual queries.</returns>  
    public string[] SplitQueryByGoCommand(string sqlQuery)
    {
        const string pattern = @"\bGO\b";
        return Regex.Split(sqlQuery, pattern, RegexOptions.Multiline);
    }

    /// <summary>
    ///     Formats an SQL query by adding line breaks before specific statements.
    /// </summary>
    /// <param name="sqlQuery">The SQL query to format.</param>
    /// <returns>The formatted SQL query.</returns>
    public string FormatSqlQuery(string sqlQuery)
    {
        sqlQuery = sqlQuery.Trim();

        sqlQuery = Regex.Replace(
            sqlQuery, @"\b(SELECT|FROM|WHERE|JOIN)\b",
            Environment.NewLine + "$1", RegexOptions.IgnoreCase);

        return sqlQuery;
    }

    /// <summary>
    ///     Validates a connection string by checking its format and the presence of user credentials.
    /// </summary>
    /// <param name="connectionString">The connection string to validate.</param>
    /// <returns><c>true</c> if the connection string is valid; otherwise, <c>false</c>.</returns>
    public bool IsValidConnectionString(string connectionString)
    {
        const string pattern = @"^(?:(?:Data Source|Server)=[^;]+;){0,1}" +
                               @"(?:Database|Initial Catalog)=[^;]+;" +
                               @"(?:User ID|UID)=[^;]+;(?:Password|PWD)=[^;]+;" +
                               @"(?:.+=.+;?)*$";

        var regex = new Regex(pattern, RegexOptions.IgnoreCase);
        var match = regex.Match(connectionString);

        return match.Success;
    }

    /// <summary>
    ///     Match a T-SQL statement that starts with SELECT, INSERT, UPDATE, DELETE, or EXECUTE
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public bool IsValidTSql(string sql)
    {
        const string pattern = @"^(SELECT|INSERT|UPDATE|DELETE|EXECUTE)\s.+$";
        return Regex.IsMatch(sql, pattern);
    }

    /// <summary>
    ///     Validates a Table name starts with specific schema. example : MySchema.People
    /// </summary>  
    /// <param name="tableName">The table name to validate.</param>
    /// <param name="schema">The schema that table name should start with.</param>
    /// <returns><c>true</c> if the table name starts with given schema; otherwise, <c>false</c>.</returns>
    public bool ValidateTableSchema(string tableName, string schema)
    {
        var pattern = @$"^{schema}\.\w+$";
        return Regex.IsMatch(tableName, pattern);
    }

    public static SqlManager Instance => LazyInstance.Value;
}