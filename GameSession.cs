namespace EscapeExe;

public static class GameSession
{
    public const int TotalSeconds = 900;

    public static string PlayerName { get; set; } = "";
    public static int TimeLeft { get; set; } = TotalSeconds;
    public static int HintsUsed { get; set; }
    public static int WrongAnswers { get; set; }
    public static int RoomsSolved { get; set; }
    public static int[] Digits { get; set; } = new int[5];

    public static void StartNewGame(string playerName)
    {
        PlayerName = playerName;
        TimeLeft = TotalSeconds;
        HintsUsed = 0;
        WrongAnswers = 0;
        RoomsSolved = 0;
        Digits = new int[5];
    }
}