namespace RoundFightStrategyMode;

public class Hero
{
    public Hero(string heroName, ISkill skill)
    {
        _heroName = heroName;
        _skill = skill;
    }
    
    public int Hp { get; set; }
    public int Mp { get; set; }
    public int Strength { get; set; }
    public int Wisdom { get; set; }
    public int Defense { get; set; }
    private string _heroName;
    private ISkill? _skill;

    
    
    public void LostMp()
    {
        Mp -= 5;
    }
    public void LostHp(int injury)
    {
        Hp += (Defense - injury);
    }
    
    public void Attack(Hero hero2)
    {
        var injury = _skill!.Attack(this, hero2);
        Console.WriteLine($"{_heroName} use {_skill.GetSkillString()} makes {hero2._heroName} hurt about {injury} hp");
        Console.WriteLine($"{hero2._heroName} gets {hero2.Hp}");
    }

    public bool IsDead()
    {
        return Hp > 0
            ? true
            : false;
    }

}