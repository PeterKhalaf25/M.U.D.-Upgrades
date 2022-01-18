//Player Class

public class Player
{
    int moveSpd = 100;
    int atkDmg = 100;
    int atkSpd = 100;
    int abilityHaste = 100;
    int abilityDmg = 100;
    int dodgeDistance = 100;

    public void statMod(float modifier, string stat)
    {
        switch (stat)
        {
            case moveSpdStat :
                moveSpd = moveSpd*modifier;

            case atkDmgStat :
                atkDmg = atkDmg*modifier;

            case atkSpdStat :
                atkSpd = atkSpd*modifier;

            case abilityHasteStat :
                abilityHaste = abilityHaste*modifier;

            case abilityDmgStat :
                abilityDmg = abilityDmg*modifier;

            case dodgeDistanceStat :
                dodgeDistance = dodgeDistance*modifier;
        }
    }
}
