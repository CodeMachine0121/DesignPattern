namespace RoundFightStrategyMode;

internal class Battle
{
    private Hero _hero1;
    private Hero _hero2;

    public Battle(Hero jamesHero, Hero jayHero)
    {
        _hero1 = jamesHero;
        _hero2 = jayHero;
    }
    
    public void Start()
    {
        _hero1.Attack(_hero2);
        
    }
}