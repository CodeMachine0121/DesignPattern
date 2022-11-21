namespace RoundFightStrategyMode;

public class WaterBall : ISkill
{
    public int Attack(Hero attackHero, Hero targetHero)
    {
        attackHero.LostMp();
        var injury = attackHero.Wisdom*2;
        targetHero.LostHp(injury);
        return injury;
    }

    public string GetSkillString()
    {
        return "WaterBall";
    }
}