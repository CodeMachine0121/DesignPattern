namespace RoundFight;

public class HeroService : IHeroService
{

    public HeroModel CreateHero(AttackType attackType)
    {
        return new HeroModel
        {
            Hp = 100,
            Mp = 50,
            DefenseValue = 10,
            StrengthValue = 10,
            WisdomValue = 5,
            AttType = attackType
        };

    }

    public int Attack(HeroModel heroModel)
    {
        return heroModel.AttackAction();
    }
    
    

    public void BeAttacked(int damageValue, HeroModel heroModel)
    {
        heroModel.DefenseAction(damageValue);
    }
    
}