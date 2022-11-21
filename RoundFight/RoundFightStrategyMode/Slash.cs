namespace RoundFightStrategyMode;

public class Slash : ISkill
{
    public int Attack(Hero attackHero, Hero targetHero)
    {
        var injury = attackHero.Strength+ 20;
        targetHero.LostHp(injury);
        return injury;
    }

    public string GetSkillString()
    {
        return "Slash";
    }
}