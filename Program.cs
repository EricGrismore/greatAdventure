using System;

namespace greatAdventure
{
    class versionOne
    {
        static void Main(string[] args)
        {
            int lives = 0, magic = 0, health = 0, direction = 0, round = 0;
            Random r = new Random();
            bool win = false;
            Console.Write("What is the name of your character? ");
            string name = Console.ReadLine();
            initValues(ref lives, ref magic, ref health, r);
            while (lives > 0 && magic > 0 && health > 0 && win == false)


            {
                direction = chooseDirection();

                /* the direction impacts the number passed to the actions method
                 * if they choose left, they will only receive bad outcomes
                 * if they choose right, they have a better chance of receiving 
                 * good outcomes along with the bad outcomes */
                if (direction == 1)
                    actions(r.Next(4), ref lives, ref magic, ref health);

                else
                    actions(r.Next(10), ref lives, ref magic, ref health);
                checkResults(ref round, ref lives, ref magic, ref health, ref win);
            }
            if (win)
                Console.WriteLine("Congratulations on successfully completing your journey!");
            else if (lives <= 0)
                Console.WriteLine("You lost too many lives and did not complete your journey");
            else if (magic <= 0)
                Console.WriteLine("You don't have any magic left and cannot complete your journey");
            else
                Console.WriteLine("You are in poor health and had to stop your journey before it's completion");

        }

        private static void checkResults(ref int round, ref int lives, ref int magic, ref int health, ref bool win)
        {
            round++;

            Console.Write("Round" + round);
            Console.Write("Lives:" + lives);
            Console.Write("Magic:" + magic);
            Console.Write("Health:" + health);

            if (round >= 25)
            {
                win = true;
            }
            else
            {
                win = false;
            }
        }

        private static void actions(int num, ref int lives, ref int magic, ref int health)
        {
            switch (num)
            {
                case 0:
                    Console.WriteLine("You met a witch that hits you with a spell.");
                    Console.WriteLine("You lose 1 unit of health and 1 unit of magic");
                    health -= 1;
                    magic -= 1;
                    break;
                case 1:
                    Console.WriteLine("You were abducted by flying monkeys and had to be rescued by a young girl and a dog");
                    Console.WriteLine("You lost 2 units of health and magic and 1 life");
                    health -= 2;
                    magic -= 2;
                    lives -= 1;
                    break;
                case 2:
                    Console.WriteLine("You steped on a trap, hurting your ankle severely bad ");
                    Console.WriteLine("You lost 2 units of health");
                    health -= 2;
                    break;

                case 3:
                    Console.WriteLine("You woke up a large fire dragon that was hungry and you were the first thing it saw");
                    Console.WriteLine("You lost 1 life");
                    lives -= 1;
                    break;

                case 4:
                    Console.WriteLine("You battle with a royal knight who's skills skills were great, but yours was better");
                    Console.WriteLine("You lost 3 health and gained 2 magic");
                    magic += 2;
                    health -= 3;
                    break;

                case 5:
                    Console.WriteLine("You find an old wizard who you graciously help. And in return he casts a spell of life on you.");
                    Console.WriteLine("The traveler granted you 2 units of health, magic and lives");
                    health += 2;
                    magic += 2;
                    lives += 1;
                    break;
                case 6:
                    Console.WriteLine("You find a migical statue that fills your soul with determination.");
                    Console.WriteLine("You gain 3 units of health and magic. And 1 life");
                    health += 3;
                    magic += 3;
                    lives += 1;
                    break;
                case 7:
                    Console.WriteLine("You find some herbs among the bushes that allow you to make some medicine");
                    Console.WriteLine("You gain 3 health");
                    health += 3;
                    break;

                case 8:
                    Console.WriteLine("you find a potion with the lable: MORE MAGIC LESS HEALTH. You drink it, but it was out of date");
                    Console.WriteLine("You gain 1 healh and lost 2 magic");
                    health += 2;
                    magic -= 2;
                    break;

                case 9:
                    Console.WriteLine("You trip over a stick and fall flat on your face");
                    Console.WriteLine("You lost 1 health");
                    health -= 1;
                    break;

                default:
                    Console.WriteLine("You saved a unicorn from a mean wizard.");
                    Console.WriteLine("You gain 2 lives and 2 units of magic");
                    magic += 2;
                    lives += 2;
                    break;
            }
        }

        private static int chooseDirection()
        {
            int direction;
            Console.WriteLine("You have come to a crossroad, enter 1 to travel left and a 2 to travel right");
            direction = int.Parse(Console.ReadLine());

            while (direction != 1 && direction != 2)
            {
                Console.WriteLine("You entered an invalid number, please enter a 1 for left or a 2 for right");
                direction = int.Parse(Console.ReadLine());
            }
            return direction;
        }

        private static void initValues(ref int lives, ref int magic, ref int health, Random r)
        {
            lives = r.Next(10) + 1;
            magic = r.Next(15) + 5;
            health = r.Next(14) + 5;
        }
    }
}
