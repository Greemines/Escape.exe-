namespace EscapeExe;

public class KeywordQuestion
{
    public string Line { get; }
    public string[] Options { get; }
    public string Answer { get; }

    public KeywordQuestion(string line, string[] options, string answer)
    {
        Line = line;
        Options = options;
        Answer = answer;
    }
}

public class LogicCircuit
{
    public string[] LampText { get; }
    public Func<bool, bool, bool, bool, bool>[] Lamps { get; }
    public bool[] Answer { get; }

    public LogicCircuit(string[] lampText, Func<bool, bool, bool, bool, bool>[] lamps, bool[] answer)
    {
        LampText = lampText;
        Lamps = lamps;
        Answer = answer;
    }
}

public static class PuzzleBank
{
    public static Random Rng { get; } = new Random();

    public static readonly List<KeywordQuestion> KeywordQuestions = new List<KeywordQuestion>
    {
        new KeywordQuestion("____ (int i = 0; i < 5; i++)", new[] { "for", "if", "int", "class" }, "for"),
        new KeywordQuestion("____ isOpen = true;", new[] { "bool", "int", "char", "string" }, "bool"),
        new KeywordQuestion("____ grade = 'A';", new[] { "char", "string", "bool", "class" }, "char"),
        new KeywordQuestion("____ (score > 50) { passed = true; }", new[] { "if", "for", "new", "int" }, "if"),
        new KeywordQuestion("____ name = \"Ali\";", new[] { "string", "char", "int", "bool" }, "string"),
        new KeywordQuestion("int[] nums = ____ int[5];", new[] { "new", "int", "var", "class" }, "new"),
        new KeywordQuestion("____ total = 3.75;", new[] { "double", "int", "char", "bool" }, "double"),
        new KeywordQuestion("public ____ Add(int a, int b) { return a + b; }", new[] { "int", "void", "class", "new" }, "int")
    };

    public static readonly List<LogicCircuit> LogicCircuits = new List<LogicCircuit>
    {
        new LogicCircuit(
            new[] { "L1 = A XOR B", "L2 = B AND C", "L3 = NOT (C AND D)" },
            new Func<bool, bool, bool, bool, bool>[]
            {
                (a, b, c, d) => a ^ b,
                (a, b, c, d) => b && c,
                (a, b, c, d) => !(c && d)
            },
            new[] { false, true, true, false }),

        new LogicCircuit(
            new[] { "L1 = A AND D", "L2 = NOT B", "L3 = C XOR D" },
            new Func<bool, bool, bool, bool, bool>[]
            {
                (a, b, c, d) => a && d,
                (a, b, c, d) => !b,
                (a, b, c, d) => c ^ d
            },
            new[] { true, false, false, true }),

        new LogicCircuit(
            new[] { "L1 = A AND B", "L2 = NOT C", "L3 = B XOR D" },
            new Func<bool, bool, bool, bool, bool>[]
            {
                (a, b, c, d) => a && b,
                (a, b, c, d) => !c,
                (a, b, c, d) => b ^ d
            },
            new[] { true, true, false, false }),

        new LogicCircuit(
            new[] { "L1 = NOT A", "L2 = B AND D", "L3 = C XOR B" },
            new Func<bool, bool, bool, bool, bool>[]
            {
                (a, b, c, d) => !a,
                (a, b, c, d) => b && d,
                (a, b, c, d) => c ^ b
            },
            new[] { false, true, false, true }),

        new LogicCircuit(
            new[] { "L1 = A XOR D", "L2 = C AND D", "L3 = NOT (A OR B)" },
            new Func<bool, bool, bool, bool, bool>[]
            {
                (a, b, c, d) => a ^ d,
                (a, b, c, d) => c && d,
                (a, b, c, d) => !(a || b)
            },
            new[] { false, false, true, true })
    };

    public static readonly string[] CipherWords =
    {
        "CLASS", "LOOP", "ARRAY", "DEBUG", "STRING",
        "METHOD", "OBJECT", "BINARY", "SYNTAX", "COMPILE"
    };

    public static int[] GenerateDigits()
    {
        int[] digits = new int[5];
        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = Rng.Next(0, 10);
        }
        return digits;
    }

    public static KeywordQuestion GetKeywordQuestion()
    {
        return KeywordQuestions[Rng.Next(KeywordQuestions.Count)];
    }

    public static string[] ShuffleOptions(string[] options)
    {
        return options.OrderBy(o => Rng.Next()).ToArray();
    }

    public static LogicCircuit GetLogicCircuit()
    {
        return LogicCircuits[Rng.Next(LogicCircuits.Count)];
    }

    public static int GenerateBinaryNumber()
    {
        return Rng.Next(5, 16);
    }

    public static string ToFourBitBinary(int number)
    {
        return Convert.ToString(number, 2).PadLeft(4, '0');
    }

    public static string GetCipherWord()
    {
        return CipherWords[Rng.Next(CipherWords.Length)];
    }

    public static int GetCipherShift()
    {
        return Rng.Next(1, 6);
    }

    public static string CaesarEncode(string word, int shift)
    {
        string result = "";
        foreach (char letter in word)
        {
            result += (char)('A' + (letter - 'A' + shift) % 26);
        }
        return result;
    }

    public static int[] GenerateTraceArray()
    {
        return Enumerable.Range(1, 9).OrderBy(n => Rng.Next()).Take(4).ToArray();
    }

    public static int[] BubbleSortOnePass(int[] input)
    {
        int[] result = (int[])input.Clone();
        for (int i = 0; i < result.Length - 1; i++)
        {
            if (result[i] > result[i + 1])
            {
                int temp = result[i];
                result[i] = result[i + 1];
                result[i + 1] = temp;
            }
        }
        return result;
    }
}