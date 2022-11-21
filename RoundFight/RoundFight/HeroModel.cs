using RoundFight;

public class HeroModel
{
    public int Hp { get; set; }
    public int Mp { get; set; }
    public int StrengthValue { get; set; }
    public int WisdomValue { get; set; }
    public int DefenseValue { get; set; }

    public AttackType AttType { get; set; }
    
    
    public void DefenseAction(int damageValue)
    {
        if (DefenseValue < damageValue)
        {
            Hp -= (DefenseValue - damageValue);
        }
    }

    public int AttackAction()
    {
        if (AttType == AttackType.MagicalAttack)
        {
            Mp -= 5;
            return WisdomValue * 2;
        }

        return StrengthValue;
    }
}