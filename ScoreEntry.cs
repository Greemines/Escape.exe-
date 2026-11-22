namespace EscapeExe;

public class ScoreEntry
{
    public string Name { get; set; } = "";
    public int Score { get; set; }
    public int TimeTakenSeconds { get; set; }
    public DateTime Date { get; set; }
    public bool Escaped { get; set; }
}