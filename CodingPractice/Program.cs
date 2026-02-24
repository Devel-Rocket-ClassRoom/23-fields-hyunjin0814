using System;
using System.Data;

// README.md를 읽고 코드를 작성하세요.

//Player player = new Player();
//player.ShowStatus();

//class Player
//{
//    private string name;
//    private int health;

//    public void ShowStatus()
//    {
//        Console.WriteLine($"이름: {this.name}");
//        Console.WriteLine($"체력: {this.health}");
//    }
//}

//Character character = new Character();
//character.name = "용사";
//character.level = 10;
//character.ShowStatus();

//class Character
//{
//    public string name;
//    public int level;

//    public void ShowStatus()
//    {
//        Console.WriteLine(name);
//        Console.WriteLine(level);
//    }
//}

//Character character = new Character();
//character.SetInfo("용사", 10);
//character.ShowStatus();

//class Character
//{
//    private string name;
//    private int level;

//    public void SetInfo(string name, int level)
//    {
//        this.name = name;
//        this.level = level;
//    }

//    public void ShowStatus()
//    {
//        Console.WriteLine($"이름: {name}");
//        Console.WriteLine($"레벨: {level}");
//    }
//}

//Player player = new Player();
//player.ShowStatus();

//class Player
//{
//    private string name = "이름없음";
//    private int health = 100;
//    private int level = 1;

//    public void ShowStatus()
//    {
//        Console.WriteLine($"이름: {name}");
//        Console.WriteLine($"체력: {health}");
//        Console.WriteLine($"레벨: {level}");
//    }
//}

//Say say = new Say();
//say.Hi();

//class Say
//{
//    private string message = "안녕하세요.";

//    public void Hi()
//    {
//        message = "반갑습니다.";
//        Console.WriteLine(message);
//    }
//}

//Schedule schedule = new Schedule();
//schedule.PrintWeekDays();

//class Schedule
//{
//    private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

//    public void PrintWeekDays()
//    {
//        foreach (var day in days)
//        {
//            Console.Write(day + "\t");
//        }
//        Console.WriteLine();
//    }
//}

//DefaultValues defaultValues = new DefaultValues();
//defaultValues.ShowDefaults();

//class DefaultValues
//{
//    private int number;
//    private bool flag;
//    private string text;

//    public void ShowDefaults()
//    {
//        Console.WriteLine($"number: {number}");
//        Console.WriteLine($"flag: {flag}");
//        Console.WriteLine("text: " + (text == null ? "null" : text));
//    }
//}

//Counter counter1 = new Counter();
//Console.WriteLine("현재 카운트: " + Counter.count);

//Counter counter2 = new Counter();
//Console.WriteLine("현재 카운트: " + Counter.count);

//Counter counter3 = new Counter();
//Console.WriteLine("현재 카운트: " + Counter.count);

//class Counter
//{
//    public static int count = 0;

//    public Counter()
//    {
//        count++;
//    }
//}

//Player player1 = new Player("용사");
//Player player2 = new Player("마법사");
//Player player3 = new Player("궁수");

//Console.WriteLine(player1.name);
//Console.WriteLine(player2.name);
//Console.WriteLine(player3.name);
//Console.WriteLine($"총 플레이어 수: {Player.totalCount}");

//class Player
//{
//    public string name;
//    public static int totalCount = 0;

//    public Player(string name)
//    {
//        this.name = name;
//        totalCount++;
//    }
//}

//GameConfig config = new GameConfig(4);
//config.ShowConfig();

//class GameConfig
//{
//    private readonly string version = "1.0.0";
//    private readonly int maxPlayers;

//    public GameConfig(int max)
//    {
//        maxPlayers = max;
//    }

//    public void ShowConfig()
//    {
//        Console.WriteLine($"버전: {version}");
//        Console.WriteLine($"최대 플레이어: {maxPlayers}");
//    }
//}

//Example ex = new Example();
//ex.ShowValues();

//class Example
//{
//    private const double Pi = 3.14159;
//    private readonly DateTime createdAt = DateTime.Now;

//    public void ShowValues()
//    {
//        Console.WriteLine($"원주율: {Pi}");
//        Console.WriteLine($"생성 시간: {createdAt}");
//    }
//}

//Player player = new Player();
//player.SetInfo("용사", 10);
//player.ShowStatus();

//class Player
//{
//    private string name;
//    private int level;

//    public void SetInfo(string name, int level)
//    {
//        this.name = name;
//        this.level = level;
//    }

//    public void ShowStatus()
//    {
//        Console.WriteLine($"이름: {name}");
//        Console.WriteLine($"레벨: {level}");
//    }
//}

//Person person = new Person();
//person.ShowProfile();

//class Person
//{
//    private string name = "홍길동";
//    private const int Age = 21;
//    private readonly string nickname = "길동이";
//    private string[] websites = { "네이버", "구글" };

//    public void ShowProfile()
//    {
//        Console.WriteLine($"이름: {name}");
//        Console.WriteLine($"나이: {Age}");
//        Console.WriteLine($"닉네임: {nickname}");
//        Console.WriteLine($"사이트: {string.Join(", ", websites)}");
//    }
//}

GameCharacter hero = new GameCharacter("용사", 15);
GameCharacter mage = new GameCharacter("마법사", 25);

hero.ShowStatus();
mage.ShowStatus();

hero.TakeDamage(30);
hero.TakeDamage(50);
hero.TakeDamage(50);

GameCharacter.ShowTotalCharacters();

class GameCharacter
{
    private string name;
    private int health;
    private int attack;

    private const int MinHealth = 0;

    private readonly int maxHealth = 100;

    private static int totalCount = 0;

    public GameCharacter(string name, int attack)
    {
        this.name = name;
        this.health = maxHealth;
        this.attack = attack;
        totalCount++;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"체력: {health}/{maxHealth}");
        Console.WriteLine($"공격력: {attack}");
        Console.WriteLine();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < MinHealth)
        {
            health = MinHealth;
        }
        Console.WriteLine($"{name}이(가) {damage} 데미지를 받음! 남은 체력: {health}");
    }

    public static void ShowTotalCharacters()
    {
        Console.WriteLine($"총 캐릭터 수: {totalCount}");
    }
}