namespace RoundFight;

public interface IHeroService
{
    public HeroModel CreateHero(AttackType attackType);
    public int Attack(HeroModel heroModel);
    
    public void BeAttacked(int damageValue, HeroModel heroModel);
}