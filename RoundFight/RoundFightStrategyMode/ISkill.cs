namespace RoundFightStrategyMode;

public interface ISkill
{
    int Attack(Hero attackHero, Hero targetHero);
    string GetSkillString();
}