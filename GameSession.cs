namespace EscapeExe;

public static class GameSession
{
    public const int TotalSeconds = 900;

    private static readonly System.Windows.Forms.Timer gameTimer = CreateTimer();

    public static string PlayerName { get; set; } = "";
    public static int TimeLeft { get; set; } = TotalSeconds;
    public static int HintsUsed { get; set; }
    public static int WrongAnswers { get; set; }
    public static int RoomsSolved { get; set; }
    public static int[] Digits { get; set; } = new int[5];

    public static int TimeTaken => TotalSeconds - TimeLeft;

    public static event Action? TimeChanged;
    public static event Action? TimeUp;

    private static System.Windows.Forms.Timer CreateTimer()
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000;
        timer.Tick += GameTimer_Tick;
        return timer;
    }

    public static void StartNewGame(string playerName)
    {
        PlayerName = playerName;
        TimeLeft = TotalSeconds;
        HintsUsed = 0;
        WrongAnswers = 0;
        RoomsSolved = 0;
        Digits = PuzzleBank.GenerateDigits();
        gameTimer.Start();
        TimeChanged?.Invoke();
    }

    public static void StopTimer()
    {
        gameTimer.Stop();
    }

    public static string FormatTime(int seconds)
    {
        if (seconds < 0)
        {
            seconds = 0;
        }
        return $"{seconds / 60:00}:{seconds % 60:00}";
    }

    private static void GameTimer_Tick(object? sender, EventArgs e)
    {
        if (TimeLeft > 0)
        {
            TimeLeft--;
        }

        TimeChanged?.Invoke();

        if (TimeLeft <= 0)
        {
            gameTimer.Stop();
            TimeUp?.Invoke();
        }
    }
}