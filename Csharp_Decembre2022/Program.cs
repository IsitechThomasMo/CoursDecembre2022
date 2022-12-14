using Csharp_Decembre2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tempo_RPG
{
    internal class Program
    {
        static void ShowText(string[] sprite)
        {
            for (int i = 0; i < sprite.Length; i++)
            {
                Console.WriteLine(sprite[i]);
            }
        }

        static void ShowSprite(string[] spriteA, string[] combatText, int enemyHealth)
        {
            for (int i = 0; i < spriteA.Length; i++)
            {
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine(spriteA[i] /*+ spriteB[i]*/);
                Console.WriteLine("  " + Player.health + "/" + Player.maxHealth + "                                     " + enemyHealth + "/ 10");
                Console.WriteLine();
                ShowText(combatText);
            }
        }

        static void PressKey()
        {
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static void Main()
        {
            int enemyHealth = 10;
            int attackTiming = 0;
            int timer = 0;
            ConsoleKeyInfo cki;

            string[] defaultCombatText = new string[]
            {
            "You're attacked by a monster!",
            "Press any key to attack"+/*, but at the right time*/"!",
            };
            string[] combatText = defaultCombatText;

            string[] animation = Sprites.FightIdle;

            while (Player.health > 0 && enemyHealth > 0 && Console.KeyAvailable == false)
            {
                attackTiming = 0;

                if (Console.KeyAvailable == false)
                {
                    combatText = defaultCombatText;
                    ShowSprite(Sprites.FightIdle, combatText, enemyHealth);
                    attackTiming++;
                    cki = Console.ReadKey(true);
                    combatText = new string[]
                    {
                        "It's your turn to attack!",
                    };
                    ShowSprite(Sprites.FightAttack, combatText, enemyHealth);
                    
                    if (/*attackTiming >= 1200 && attackTiming <= 1800 ||*/ attackTiming >= 1)
                    {
                        //animation = Sprites.FightIdle;
                        cki = Console.ReadKey(true);

                        combatText = new string[]
                        {
                            "You attacked and did damage!",
                        };
                        enemyHealth -= Player.baseDamage;
                        ShowSprite(Sprites.FightIdle, combatText, enemyHealth);
                        //ShowText(combatText);
                        PressKey();
                        if (enemyHealth <= 0)
                        {
                            Console.Clear();
                            combatText = new string[]
                            {
                            "You defeated the monster!",
                            "",
                            "",
                            };
                            ShowText(combatText);
                            PressKey();

                            return;
                        }
                    }
                    else if (attackTiming > 1800 && attackTiming <= 2400)
                    {
                        cki = Console.ReadKey(true);

                        //animation = Sprites.FightAttackPerfected;
                        combatText = new string[]
                        {
                            "You attacked at the perfect time and did a lot of damage!",
                        };
                        enemyHealth -= Player.timedDamage;
                        ShowText(combatText);
                        PressKey();
                        if (enemyHealth <= 0)
                        {
                            Console.Clear();
                            combatText = new string[]
                            {
                            "You defeated the monster!",
                            "",
                            "",
                            };
                            ShowText(combatText);
                            PressKey();
                            return;
                        }
                    }
                    else
                    {
                        //animation = Sprites.FightAttackMissed;
                        cki = Console.ReadKey(true);

                        combatText = new string[]
                        {
                            "You attacked, but missed!",
                        };
                        ShowText(combatText);
                        PressKey();
                    }
                    attackTiming = 0;
                    if (enemyHealth > 0)
                    {
                        combatText = new string[]
                        {
                            "You're attacked by the monster!",
                        };

                        ShowSprite(Sprites.FightHit, combatText, enemyHealth);
                        Player.health -= 2;
                        PressKey();
                        if (Player.health <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" You died");
                            Console.WriteLine(" .");
                            Console.WriteLine(" .");
                            Console.WriteLine(" .");
                            return;
                        }
                    }
                }
            }
        }
    }
}