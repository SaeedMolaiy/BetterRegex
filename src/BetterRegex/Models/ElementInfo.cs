namespace BetterRegex.Models
{
    public class ElementInfo
    {
        internal ElementInfo()
        {
        }

        public string? TagName { get; set; }

        public string? Id { get; set; }

        public string? Value { get; set; }

        public string? Placeholder { get; set; }

        public Dictionary<string, string>? Attributes { get; set; }

        public IDictionary<string, string>? Styles { get; set; }
    }
}