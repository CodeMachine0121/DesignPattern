// See https://aka.ms/new-console-template for more information

namespace RoundFightStrategyMode;

class Prgogram
{
    public static void Main(string[] args)
    {
        var jayHero = new Hero("jay", new Slash())
        {
            Hp = 100,
            Mp = 50,
            Strength = 15,
            Wisdom = 10,
            Defense = 5
        };
        var jamesHero = new Hero("james", new WaterBall())
        {
            Hp = 100,
            Mp = 50,
            Strength = 10,
            Wisdom = 15,
            Defense = 5
        };

        var battle = new Battle(jamesHero, jayHero);
        battle.Start();
    }
}