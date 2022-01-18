//Weapon Class

public class Weapon
{
    bool ranged = true;

    int meleeDmg = 100;
    int rangeDmg = 100;
    int atkRange = 100;
    int fireRate = 100;
    // int durability = 100;
    int ammo = 100;

    public void dmgMod(float modifier)
    {
        if (ranged)
        {
            rangeDmg = rangeDmg*modifier;
        } else
        {
            meleeDmg = meleeDmg*modifier;
        }
    }

}