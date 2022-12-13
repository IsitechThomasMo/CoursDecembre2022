using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Decembre2022
{
}

public class Player
{
    public static int maxHealth = 10;
    public static int health = maxHealth;

    public static int baseDamage = 2;
    public static int timedDamage = baseDamage * 2;
    public static int missedDamage = baseDamage / 2;
}
