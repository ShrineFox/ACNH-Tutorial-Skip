using System.Text.RegularExpressions;

namespace CombineEVFL
{
    internal class Program
    {
        const int MinRepeatLength = 20;

        static void Main(string[] args)
        {
            foreach (var file in Directory.GetFiles(args[0]))
            {
                var lines = File.ReadAllLines(file);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (!lines[i].Contains(",") && !lines[i].TrimEnd().EndsWith(":"))
                    {
                        lines[i] = RemoveRepeatedSubstrings(lines[i], MinRepeatLength);
                    }
                }

                File.WriteAllText(file, string.Join("\r\n", lines).Replace("    ", "\t").Replace("\r\n ", "\r\n"));
            }
        }

        static string RemoveRepeatedSubstrings(string input, int minLen)
        {
            var seen = new HashSet<string>();
            int maxWindow = input.Length / 2;

            for (int window = maxWindow; window >= minLen; window--)
            {
                for (int i = 0; i <= input.Length - window; i++)
                {
                    string substr = input.Substring(i, window);

                    if (seen.Contains(substr))
                    {
                        // Remove all other occurrences except the first one
                        int firstIndex = input.IndexOf(substr);
                        int nextIndex = input.IndexOf(substr, firstIndex + 1);
                        while (nextIndex != -1)
                        {
                            input = input.Remove(nextIndex, substr.Length);
                            nextIndex = input.IndexOf(substr, nextIndex);
                        }
                    }
                    else
                    {
                        seen.Add(substr);
                    }
                }
            }

            return input;
        }
    }
}
