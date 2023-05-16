using System.Text;
using System.Text.RegularExpressions;

namespace BetterRegex.Primitive
{
    public class RegexBuilder
    {
        private readonly StringBuilder _patternBuilder;

        public RegexBuilder()
        {
            _patternBuilder = new StringBuilder();
        }

        /// <summary>
        ///     Adds the start of line anchor (^) to the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder StartOfLine()
        {
            _patternBuilder.Append("^");
            return this;
        }

        /// <summary>
        ///     Adds the end of line anchor ($) to the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder EndOfLine()
        {
            _patternBuilder.Append("$");
            return this;
        }

        /// <summary>
        ///     Matches any single character (except for newline characters) in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder AnyCharacter()
        {
            _patternBuilder.Append(".");
            return this;
        }

        /// <summary>
        ///     Matches a digit character (0-9) in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder Digit()
        {
            _patternBuilder.Append("\\d");
            return this;
        }

        /// <summary>
        ///     Matches a word character (letter, digit, or underscore) in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder WordCharacter()
        {
            _patternBuilder.Append("\\w");
            return this;
        }

        /// <summary>
        ///     Adds a literal string value to the regular expression pattern.
        /// </summary>
        /// <param name="value">The string value to be added as a literal.</param>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder Literal(string value)
        {
            _patternBuilder.Append(Regex.Escape(value));
            return this;
        }

        /// <summary>
        ///     Matches one or more occurrences of the preceding element in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder MatchOneOrMore()
        {
            _patternBuilder.Append("+");
            return this;
        }

        /// <summary>
        ///     Matches zero or more occurrences of the preceding element in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder MatchZeroOrMore()
        {
            _patternBuilder.Append("*");
            return this;
        }

        /// <summary>
        ///     Matches zero or one occurrence of the preceding element in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder MatchZeroOrOne()
        {
            _patternBuilder.Append("?");
            return this;
        }

        /// <summary>
        ///     Adds a group to the regular expression pattern, allowing capturing or non-capturing of the grouped elements.
        /// </summary>
        /// <param name="groupBuilder">A callback function to build the contents of the group.</param>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder Group(Action<RegexBuilder> groupBuilder)
        {
            _patternBuilder.Append("(");
            groupBuilder(this);
            _patternBuilder.Append(")");
            return this;
        }

        /// <summary>
        ///     Adds a positive lookahead assertion to the regular expression pattern.
        /// </summary>
        /// <param name="lookaheadBuilder">A callback function to build the contents of the lookahead assertion.</param>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder PositiveLookahead(Action<RegexBuilder> lookaheadBuilder)
        {
            _patternBuilder.Append("(?=");
            lookaheadBuilder(this);
            _patternBuilder.Append(")");
            return this;
        }

        /// <summary>
        ///     Adds a negative lookahead assertion to the regular expression pattern.
        /// </summary>
        /// <param name="lookaheadBuilder">A callback function to build the contents of the lookahead assertion.</param>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder NegativeLookahead(Action<RegexBuilder> lookaheadBuilder)
        {
            _patternBuilder.Append("(?!");
            lookaheadBuilder(this);
            _patternBuilder.Append(")");
            return this;
        }

        /// <summary>
        ///     Matches a specific character in the regular expression pattern.
        /// </summary>
        /// <param name="character">The character to match.</param>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder Character(char character)
        {
            _patternBuilder.Append(character);
            return this;
        }

        /// <summary>
        ///     Matches any character that is not in the provided set of characters in the regular expression pattern.
        /// </summary>
        /// <param name="characters">The set of characters to exclude.</param>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder NotCharacters(params char[] characters)
        {
            _patternBuilder.Append("[^");
            _patternBuilder.Append(Regex.Escape(new string(characters)));
            _patternBuilder.Append("]");
            return this;
        }

        /// <summary>
        ///     Matches any whitespace character in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder Whitespace()
        {
            _patternBuilder.Append("\\s");
            return this;
        }

        /// <summary>
        ///     Matches a specific word boundary in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder WordBoundary()
        {
            _patternBuilder.Append("\\b");
            return this;
        }

        /// <summary>
        ///     Matches a specific character or character range in the regular expression pattern.
        /// </summary>
        /// <param name="startCharacter">The start character of the range.</param>
        /// <param name="endCharacter">The end character of the range.</param>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder CharacterRange(char startCharacter, char endCharacter)
        {
            _patternBuilder.Append("[");
            _patternBuilder.Append(startCharacter);
            _patternBuilder.Append("-");
            _patternBuilder.Append(endCharacter);
            _patternBuilder.Append("]");
            return this;
        }


        /// <summary>
        ///     Matches any non-digit character in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder NonDigit()
        {
            _patternBuilder.Append("\\D");
            return this;
        }

        /// <summary>
        ///     Matches any non-word character in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder NonWordCharacter()
        {
            _patternBuilder.Append("\\W");
            return this;
        }

        /// <summary>
        ///     Matches any whitespace or line break character in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder WhiteSpaceOrLineBreak()
        {
            _patternBuilder.Append("\\s");
            _patternBuilder.Append("|");
            _patternBuilder.Append("\\n");
            _patternBuilder.Append("\\r");
            _patternBuilder.Append("\\t");
            return this;
        }

        /// <summary>
        ///     Matches any character in the specified character set in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder CharSet(string charSet)
        {
            _patternBuilder.Append("[");
            _patternBuilder.Append(charSet);
            _patternBuilder.Append("]");
            return this;
        }

        /// <summary>
        ///     Matches any character that is not in the specified character set in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder NotCharSet(string charSet)
        {
            _patternBuilder.Append("[^");
            _patternBuilder.Append(charSet);
            _patternBuilder.Append("]");
            return this;
        }

        /// <summary>
        ///     Matches any character that is a word character (alphanumeric or underscore) in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder WordChar()
        {
            _patternBuilder.Append("\\w");
            return this;
        }

        /// <summary>
        ///     Matches any non-whitespace character in the regular expression pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder NonWhitespace()
        {
            _patternBuilder.Append("\\S");
            return this;
        }

        /// <summary>
        ///     Appends a new line character (\n) to the regex pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder NewLine()
        {
            _patternBuilder.Append("\\n");
            return this;
        }

        /// <summary>
        ///     Appends a tab character (\t) to the regex pattern.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder Tab()
        {
            _patternBuilder.Append("\\t");
            return this;
        }

        /// <summary>
        ///     Clears the current regex pattern being built.
        /// </summary>
        /// <returns>The <see cref="RegexBuilder"/> instance for method chaining.</returns>
        public RegexBuilder Clear()
        {
            _patternBuilder.Clear();
            return this;
        }

        /// <summary>
        ///     Builds and retrieves the final regular expression pattern.
        /// </summary>
        public string Build()
        {
            return _patternBuilder.ToString();
        }
    }
}