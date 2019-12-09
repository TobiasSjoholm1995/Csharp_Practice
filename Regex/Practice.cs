using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyRegex {
    /// Regex can be instansiated but short lines of code to use static overload
    public class Practice {

        public Practice() {
            test1();
            cheatSheet();
            isMatch();
            match();
            matches();
            replace();
            split();
        }

        private void test1() {
            string input = @"/.+?\+";

            Match m = Regex.Match(input, @"[\""].+?[\""]|[^ ]+", RegexOptions.IgnoreCase);

            if (m.Success)
                Console.WriteLine("Testing:\n\t" + input + " --> " + m.Value);

        }

        private void test2() {
            string input = "hever";

            MatchCollection cm = Regex.Matches(input, @"z*", RegexOptions.IgnoreCase);

            Console.Write("Testing:\n\t" + input + " --> ");
            foreach (var item in cm)
                Console.Write(item + " ");
            Console.WriteLine();
        }


        private void cheatSheet() {
            string[] patterns = {
                @"[a-z]  - Matches any character in range, this case lowecase alphabet" ,
                @"x|y    - Matches x or y",
                @".      - Matches any single character except a newline character",
                @"+      - Matches the preceding character ONE or more times",
                @"*      - Matches the preceding character ZERO or more times",
                @"a{n}   - Match 'a' n times, n is a non negative number",
                @"a{n}   - Match 'a' n or more times, n is a non negative number",
                @"a{n,m} - Match 'a' n to m times",
                @"[^a21] - Matches any character not in set" ,
                @"[^m-z] - Matches any character not in range",
                @"\b     - Match preceding character at the boundrary of a word",
                @"\d     - Matches a digit",
                @"\num   - Matches a postive integer",
                @"\n     - Matches new line",
                @"\Z     - Matches position of last symbol in string",
                @"\a     - Matches position of first symbol in string",
                @"\w     - Matches a word character including underscore. Equivalent to [A-Za-z0-9_]",
            };

            Console.WriteLine("Cheat Sheet:");
            foreach (var item in patterns)
                Console.WriteLine("\t" + item);
        }

        private void isMatch() {
            string input = "A12";

            bool m = Regex.IsMatch(input, @"[a-z]\d", RegexOptions.IgnoreCase);

            if (m)
                Console.WriteLine("IsMatch:\n\t" + input);
        }

        private void match() {
            string input = "A12";

            Match m = Regex.Match(input, @"[a-z]\d", RegexOptions.IgnoreCase);

            if (m.Success) 
                Console.WriteLine("Match:\n\t" + input + " --> " + m.Value);
        }

        private void matches() {
            string input = "A12 B34 C56 D78 7R";

            MatchCollection mc = Regex.Matches(input, @"[a-z]\d", RegexOptions.IgnoreCase);

            Console.Write("Matches:\n\t" + input + " --> ");
            foreach (Match value in mc) 
                Console.Write(value.ToString() + " ");
            Console.WriteLine();
        }

        private void replace() {
            string input = @"A12 B34 C56 D78";

            string value = Regex.Replace(input, @"[a-z]\d", "XX", RegexOptions.IgnoreCase);

            Console.WriteLine("Replace:\n\t" + input + "-- >  " + value);
        }

        private void split() {
            string input = @"A1,B2,C3";

            string[] splitted = Regex.Split(input, ",", RegexOptions.IgnoreCase);

            Console.Write("Split:\n\t" + input + "  -->  ");
            foreach (string value in splitted) 
                Console.Write(value.Trim() + " ");
            Console.WriteLine();
        }

    }
}
