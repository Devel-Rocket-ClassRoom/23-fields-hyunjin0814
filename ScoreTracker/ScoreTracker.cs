using System;

class ScoreTracker
{
    private const int MaxScore = 100;
    private const int MinScore = 0;
    private readonly string subName;
    private int score = MinScore;
    private int bonusCount = 0;

    public ScoreTracker(string subName)
    {
        this.subName = subName;
    }

    public void SetScore(int score)
    {
        if (score < MinScore || score > MaxScore)
        {
            Console.WriteLine($"점수는 {MinScore}~{MaxScore} 사이여야 합니다.");
        }
        else
        {
            this.score = score;
            Console.WriteLine($"점수를 {score}점으로 설정했습니다.");
        }
    }

    public void AddBonus(int bonus)
    {
        score += bonus;
        bonusCount++;

        if (score > MaxScore)
        {
            score = MaxScore;
            Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {score}점 (최대 점수 도달)");
        }
        else
        {
            Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {score}점");
        }

    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {subName} ===");
        Console.WriteLine($"점수: {score} / {MaxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonusCount}");
    }
}
