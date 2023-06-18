using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace StalkerConsoleQuest
{
    class Game
    {
        

        public static void Main(string[] args)
        {
           

            Console.Title = "История сталкера Химика";
            Console.WriteLine("НАЖМИТЕ Enter");
            Console.Read();
            MainMenu();
        }

        public static ConsoleKey GetButton()
        {
            while (true) // повторяем, пока не будет получена нужная клавиша
            {
                var key = Console.ReadKey(true).Key; // получаем нажатую клавишу

                if (key >= ConsoleKey.D0 && key <= ConsoleKey.D3) // проверяем клавишу на соответствие нужным
                {
                    return key; // возвращаем клавишу
                }
                /*else if (key == ConsoleKey.NumPad0 || key == ConsoleKey.NumPad1 ||
                         key == ConsoleKey.NumPad2 || key == ConsoleKey.NumPad3 ||
                         key == ConsoleKey.NumPad4 || key == ConsoleKey.NumPad5 ||
                         key == ConsoleKey.NumPad6 || key == ConsoleKey.NumPad7 ||
                         key == ConsoleKey.NumPad8 || key == ConsoleKey.NumPad9)
                {
                    return key; // возвращаем клавишу
                }*/
            }
        }

        public static void MainMenu()
        {
            string language_RU = "Русский";
            string language_EN = "English";

            
           //Console.Read();
            Console.Clear();

            Console.WriteLine(" Выберите язык ");
            Console.WriteLine("___________________");
            Console.WriteLine($"1. {language_RU}");
            Console.WriteLine($"2. {language_EN}");

            ConsoleKey key = GetButton();

            Console.Clear();

            //русская локализация
            if (key == ConsoleKey.D1) 
            {
            //menu:
                Console.Clear();
                Console.WriteLine("История сталкера Химика. Демо-версия");
                Console.WriteLine("_______________________________________ ");
                Console.WriteLine("1. Начать игру");
                Console.WriteLine("2. Выход");

                ConsoleKey key1 = GetButton();


                Console.Clear();
                if (key1 == ConsoleKey.D1)
                {
                    GamePrologue_RU();
                }

                if (key1 == ConsoleKey.D2)
                {
                    Environment.Exit(0);
                }

            }

            // английская локализация
            if (key == ConsoleKey.D2)
            {
            //menu1:
                Console.Clear();
                Console.WriteLine("The Story of Stalker Chemist Demo.");
                Console.WriteLine("______________________________________");
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. Exit");

                ConsoleKey key1 = GetButton();


                Console.Clear();
                if (key1 == ConsoleKey.D1)
                {
                    GamePrologue_EN();
                }

                if (key1 == ConsoleKey.D2)
                {
                    Environment.Exit(0);
                }

            }

        }

        /*Английская локализация
        || || || || ||
        \/ \/ \/ \/ \/
        */

        public static void GamePrologue_EN()
        {
            Console.Clear();
            Console.WriteLine("You can skip Prologue. Skip?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            ConsoleKey key2 = GetButton();

            if (key2 == ConsoleKey.D1)
            {
                Game_Level1_EN();
            }

            else if (key2 == ConsoleKey.D2)
            {
                Prologue_EN();
            }
        }
        
        public static void Prologue_EN(){
 
            Console.Clear();
            Console.WriteLine("The Story of Stalker Chemist.");
            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine
                (@"
                    2004. Chernobyl Exclusion Zone.
                    The second explosion at the nuclear power plant 
                    turned the territory into a very dangerous place.
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Mutants and anomalies filled the 30-kilometer Exclusion Zone. 
                    People who are in this territory call themselves stalkers.
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    They penetrate there, bypassing the military's protective checkpoints. 
                    Everyone who gets into the Zone somehow becomes dependent on It.
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    For them, there is a choice, although it is not great, 
                    to survive at any cost and get out of the Zone, or stay 
                    there forever. This is the history of the Zone, its origin.
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    And my story began 30 years later.
                    You may ask how I got here and why?
                    Am I crazy or something? No...
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    My girlfriend was kidnapped. And I had to go to her rescue, 
                    because I promised her mother to protect her at any cost, 
                    even at the cost of my life...
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    It was quite easy to get into the territory, 
                    because I have connections with the military. 
                    However, this is a completely different story...
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    There is usually no name in the Zone, but there are call signs.
                ");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine
                (@"
                    My name is a Chemist and this is my story.
                ");
            Thread.Sleep(5000);
            Console.Clear();

            Game_Level1_EN();

        }
        
        public static void Game_Level1_EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    The chemist moves through ruined buildings and dangerous areas,
                    watching out for mutants and avoiding them.
                        ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Keep watching.");
            Console.WriteLine("2. Attack.");
            //Console.WriteLine("3.");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key3 = GetButton();

            if (key3 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key3 == ConsoleKey.D1)
            {
                Game_Level1_1EN();
            }
            if (key3 == ConsoleKey.D2)
            {
                Game_Level_1_2_EN();
            }
        }
       
        public static void Game_Level1_1EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Now the chemist knows some habits and vulnerable spots of the mutants,
                    which may come in handy for him in the future.
                    ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Continue.");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key3 = GetButton();

            if (key3 == ConsoleKey.D0)
            {
                MainMenu();
            }
            if (key3 == ConsoleKey.D1)
            {
                Game_Level2_EN();
            }
        }
        
        public static void Game_Level_1_2_EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    The chemist decided to attack the mutants.
                    What will happen next?
            ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Use his weapons and tactical skills to destroy the mutant.");
            Console.WriteLine("2. Receive damage and lose his weapon if not careful.");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key3 = GetButton();

            if (key3 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key3 == ConsoleKey.D1)
            {
                Game_Level2_EN();
            }
            if (key3 == ConsoleKey.D2)
            {
                Game_Level2_EN();
            }
        }
        
        public static void Game_Level2_EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Soon he meets other stalkers who help him in his search for his beloved.
");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"
                    1. They go in search of information on which mutants to avoid and what weapons
                       are best used for their destruction.");
            Console.WriteLine(@"
                    2. During their search, they come across a camp of one of the bandit groups that
                       control the zone and demand money from stalkers for passing through certain areas.");
            Console.WriteLine(@"
                    3. The chemist and his allies decide to act quickly and attack the camp.");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key4 = GetButton();

            if (key4 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key4 == ConsoleKey.D1)
            {
                Game_Level2_1EN();
            }

            if (key4 == ConsoleKey.D2)
            {
                Game_Level2_2EN();
            }

            if (key4 == ConsoleKey.D3)
            {
                Game_Level2_3EN();
            }
        }

        public static void Game_Level2_1EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    The Chemist received useful information that can help him in the future.
");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Continue.");
            Console.WriteLine("0. Exit to menu.");
            ConsoleKey key4 = GetButton();

            if (key4 == ConsoleKey.D0)
            {
                MainMenu();
            }
            if (key4 == ConsoleKey.D1)
            {
                Game_Level3_EN();
            }
        }

        public static void Game_Level2_2EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    The Chemist decided to pay the money and continue his journey, 
                    or attack the bandits and risk his life.
");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Pay the money.");
            Console.WriteLine("2. Attack and take the risk.");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key4 = GetButton();

            if (key4 == ConsoleKey.D0)
            {
                MainMenu();
            }
            if (key4 == ConsoleKey.D1)
            {
                Game_Level3_EN();
            }

            if (key4 == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine(@"
                        GAME OVER

                 The bandits killed the Chemist.
");
                Thread.Sleep(1000);
                MainMenu();
            }
        }

        public static void Game_Level2_3EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    The Chemist received valuable items and records that can help him in his search,
                    but he also risks his life.
");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Continue.");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key4 = GetButton();

            if (key4 == ConsoleKey.D0)
            {
                MainMenu();
            }
            if (key4 == ConsoleKey.D1)
            {
                Game_Level3_EN();
            }
        }

        public static void Game_Level3_EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    However, when they find a cliff behind which is the base of the kidnappers,
                    the Chemist realizes that he will have to make a difficult decision:
                    go for direct confrontation or try to set the enemies against each other.
");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. The chemist goes for direct confrontation and attacks the kidnapper base.");
            Console.WriteLine("2. The chemist tries to set the enemies against each other to kill them with less effort.");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key5 = GetButton();

            if (key5 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key5 == ConsoleKey.D1)
            {
                Game_Level3_1EN();
            }

            if (key5 == ConsoleKey.D2)
            {
                Game_Level3_2EN();
            }
        }

        public static void Game_Level3_1EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    The Chemist received valuable information or items, but he also risks his life.
");
            Game_Slashes();
            Console.WriteLine("1. Continue");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key5 = GetButton();

            if (key5 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key5 == ConsoleKey.D1)
            {
                Game_Level4_EN();
            }
        }

        public static void Game_Level3_2EN()
        {
            Console.Clear();
            Console.WriteLine(@"
            The Chemist sets the enemies against each other and manages to avoid direct confrontation.
");
            Game_Slashes();
            Console.WriteLine("1. Continue");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key5 = GetButton();

            if (key5 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key5 == ConsoleKey.D1)
            {
                Game_Level4_EN();
            }
        }

        public static void Game_Level4_EN()
        {
            Console.Clear();
            Console.WriteLine(@"
                    The Chemist finally reaches the kidnappers' base where his beloved is being held.
");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. The chemist tries to sneak into the base.");
            Console.WriteLine("2. The chemist goes for a direct attack on the base.");
            Console.WriteLine("0. Exit to menu.");

            ConsoleKey key6 = GetButton();

            if (key6 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key6 == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine(@"
                        The Chemist manages to sneak into the base unnoticed and frees his beloved. 
                        They escape together and leave the zone behind.
            ");
                Game_Slashes();
                Console.WriteLine("1. End of game");
                Console.WriteLine("0. Exit to menu.");

                ConsoleKey key7 = GetButton();

                if (key7 == ConsoleKey.D0)
                {
                    MainMenu();
                }

                if (key7 == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing!");
                    Thread.Sleep(3000);
                    Game_Exit_EN();
                }
            }

            if (key6 == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine(@"
                        The Chemist goes for a direct attack and manages to rescue his beloved, 
                        but they are both injured and have to fight their way out of the zone. 
                        They eventually make it out and leave the zone behind.");
                Game_Slashes();

                Console.WriteLine("1. End of game");
                Console.WriteLine("0. Exit to menu.");

                ConsoleKey key7 = GetButton();

                if (key7 == ConsoleKey.D0)
                {
                    MainMenu();
                }

                if (key7 == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing!");
                    Thread.Sleep(3000);
                    Game_Exit_EN();
                }
            }
        }

        public static void Game_Exit_EN()
        {
            /*Console.WriteLine("The rest is under development...");
            Console.WriteLine(@"Thanks for playing.");
            Thread.Sleep(2000);*/
            Console.Clear();
            Console.WriteLine("The application will close automatically in: 3");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("The application will close automatically in: 2");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("The application will close automatically in: 1");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        /*Русская локализация
        || || || || ||
        \/ \/ \/ \/ \/
        */

        public static void GamePrologue_RU()
        {
            Console.Clear();
            Console.WriteLine("Вы хотите пропустить пролог?");
            Console.WriteLine("1. Да");
            Console.WriteLine("2. Нет");

            ConsoleKey key2 = GetButton();

            if (key2 == ConsoleKey.D1)
            {
                Game_Level1_RU();
            }

            else if (key2 == ConsoleKey.D2)
            {
                Prologue_RU();
            }
        }
       
        public static void Prologue_RU(){
        
            Console.Clear();
            Console.WriteLine("История сталкера Химика. Пролог.");
            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine
                (@"
                    2004. Чернобыльская Зона Отчуждения.
                    Второй взрыв на атомной электростанции
                    превратил территорию в очень опасное место.
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Мутанты и аномалии заполнили 30-километровую зону отчуждения.
                    Люди, которые находятся на этой территории, называют себя сталкерами.
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Они проникают туда, минуя защитные блокпосты военных. 
                    Каждый, кто попадает в Зону, так или иначе становится зависимым от Нее.
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Для них есть выбор, хотя он и не велик,
                    выжить любой ценой и выбраться из Зоны или остаться
                    там навсегда. Это история Зоны, ее происхождение.
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Моя история началась 30 лет спустя.
                    Вы можете спросить, как я сюда попал и почему?
                    Я сумасшедший или что-то в этом роде? Нет...
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Мою девушку похитили. И я должен был прийти ей на помощь,
                    потому что я обещал ее матери защитить ее любой ценой,
                    даже ценой своей жизни...
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Попасть на территорию было довольно легко,
                    потому что у меня есть связи с военными. 
                    Однако это совершенно другая история...
                ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Обычно в Зоне нет имени, но есть позывные.
                ");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine
                (@"
                    Меня зовут Химик и это моя история.
                ");
            Thread.Sleep(5000);
            Console.Clear();
            
            Game_Level1_RU();

        }

        public static void Game_Level1_RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                       Химик продвигается через разрушенные здания и опасные зоны, 
                       наблюдая за мутантами и избегая их.
            ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Продолжать смотреть.");
            Console.WriteLine("2. Напасть.");
            //Console.WriteLine("3.");
            Console.WriteLine("0. Выход в меню.");
            
            ConsoleKey key3 = GetButton();

            if (key3 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key3 == ConsoleKey.D1)
            {
                Game_Level1_1RU();
            }
            if (key3 == ConsoleKey.D2)
            {
                Game_Level_1_2_RU();
            }
        }

        public static void Game_Level1_1RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                        Теперь Химик знает некоторые привычки и уязвимые места мутантов, 
                        которые могут пригодиться ему в будущем.
                ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Продолжить.");
            Console.WriteLine("0. Выход в меню.");

            ConsoleKey key3 = GetButton();

            if (key3 == ConsoleKey.D0)
            {
                MainMenu();
            }
            if (key3 == ConsoleKey.D1)
            {
                Game_Level2_RU();
            }
        }

        public static void Game_Level_1_2_RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Химик решил напасть на мутантов.
                    Что будет дальше?
            ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Использует свое оружие и тактические навыки для уничтожения мутанта.");
            Console.WriteLine("2. Получит урон и потеряет свое оружие, если не осторожен.");
            Console.WriteLine("0. Выход в меню.");
            ConsoleKey key3 = GetButton();

            if (key3 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key3 == ConsoleKey.D1)
            {
                Game_Level2_RU();
            }
            if (key3 == ConsoleKey.D2)
            {
                Game_Level2_RU();
            }
        }

        public static void Game_Level2_RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Вскоре он встречает других сталкеров, 
                    которые помогают ему с поисками его возлюбленной. 
            ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"
                 1. Они отправляются на поиски информации о том, 
                    каких мутантов нужно избегать и какое оружие 
                    лучше использовать для их уничтожения.");
            Console.WriteLine(@"
                 2. В ходе поисков они находят лагерь одной 
                    из бандитских группировок, которые 
                    контролируют зону и требуют от сталкеров 
                    деньги за проход через определенные участки.");
            Console.WriteLine(@"
                 3. Химик и его союзники решают действовать быстро и нападают на лагерь.");
            Console.WriteLine("0. Выход в меню.");

            ConsoleKey key4 = GetButton();

            if (key4 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key4 == ConsoleKey.D1)
            {
                Game_Level2_1RU();
            }

            if (key4 == ConsoleKey.D2)
            {
                Game_Level2_2RU();
            }

            if(key4 == ConsoleKey.D3)
            {
                Game_Level2_3RU();
            }
        }

        public static void Game_Level2_1RU()
        {
            Console.Clear();
            Console.WriteLine(@"
        Химик получил полезную информацию, которая может помочь ему в дальнейшем.
                ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Продолжить.");
            Console.WriteLine("0. Выход в меню.");
            ConsoleKey key4 = GetButton();

            if (key4 == ConsoleKey.D0)
            {
                MainMenu();
            }
            if (key4 == ConsoleKey.D1)
            {
                Game_Level3_RU();
            }
        }

        public static void Game_Level2_2RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Химик решил заплатить деньги и продолжить свое путешествие, 
                    или напасть на бандитов и рискнуть своей жизнью.
                ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Заплатить деньги.");
            Console.WriteLine("2. Напасть и рискнуть.");
            Console.WriteLine("0. Выход в меню.");

            ConsoleKey key4 = GetButton();

            if (key4 == ConsoleKey.D0)
            {
                MainMenu();
            }
            if (key4 == ConsoleKey.D1)
            {
                Game_Level3_RU();
            }

            if (key4 == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine(@"
                ИГРА ОКОНЧЕНА

            Бандиты убили Химика.
");
                Thread.Sleep(1000);
                MainMenu();
            }
        }

        public static void Game_Level2_3RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Химик получил ценные предметы и записи, 
                    которые могут помочь ему в его поисках, 
                    но он также рискует своей жизнью.
                ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Продолжить.");
            Console.WriteLine("0. Выход в меню.");

            ConsoleKey key4 = GetButton();

            if (key4 == ConsoleKey.D0)
            {
                MainMenu();
            }
            if (key4 == ConsoleKey.D1)
            {
                Game_Level3_RU();
            }
        }

        public static void Game_Level3_RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Однако, когда они находят обрыв, за которым находится база похитителей, 
                    Химик понимает, что нужно будет принять тяжелое решение: 
                    идти на прямую конфронтацию или попытаться подставить врагов друг к другу.
            ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Химик идет на прямую конфронтацию и нападает на базу похитителей.");
            Console.WriteLine("2. Химик пытается подставить врагов друг к другу, чтобы убить их меньшими усилиями.");
            Console.WriteLine("0. Выход в меню.");

            ConsoleKey key5 = GetButton();

            if (key5 == ConsoleKey.D0)
            {
                MainMenu();
            }
            
            if (key5 == ConsoleKey.D1)
            {
                Game_Level3_1RU();
            }

            if (key5 == ConsoleKey.D2)
            {
                Game_Level3_2RU();
            }
        }

        public static void Game_Level3_1RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Химик получил ценную информацию или предметы, 
                    но он также рискует своей жизнью.
            ");
            Game_Slashes();
            Console.WriteLine("1. Продолжить");
            Console.WriteLine("0. Выход в меню.");

            ConsoleKey key5 = GetButton();

            if (key5 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key5 == ConsoleKey.D1)
            {
                Game_Level4_RU();
            }
        }

        public static void Game_Level3_2RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Химик может использовать свои тактические навыки и ловкость, 
                    чтобы добраться до его возлюбленной и освободить ее.
");
            Game_Slashes();
            Console.WriteLine("1. Продолжить");
            Console.WriteLine("0. Выход в меню.");

            ConsoleKey key5 = GetButton();

            if (key5 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key5 == ConsoleKey.D1)
            {
                Game_Level4_RU();
            }
        }

        public static void Game_Level4_RU()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Теперь у Химика есть выбор: попытаться сбежать, 
                    пережить множество опасностей Зоны и продолжить жизнь со своей возлюбленной, 
                    или остаться и защищать Зону другим сталкерам. 
            ");
            Game_Slashes();
            Console.WriteLine("1. Химик решил сбежать с его возлюбленной и начать новую жизнь в другом месте.");
            Console.WriteLine("2. Химик решил остаться и защищать Зону от всех опасностей, которые могут угрожать ей.");
            Console.WriteLine("0. Выход в меню.");

            ConsoleKey key5 = GetButton();

            if (key5 == ConsoleKey.D0)
            {
                MainMenu();
            }

            if (key5 == ConsoleKey.D1)
            {
                Game_Final();
            }

            if (key5 == ConsoleKey.D2)
            {
                Game_Final();
            }
        }

        public static void Game_Final()
        {
            Console.Clear();
            Console.WriteLine(@"
                    Химик и его возлюбленная покидают Зону, 
                    но Химик выбрал остаться и добиваться 
                    своей цели - защиты территории и ее обитателей.
                    Вскоре Химик стал легендарным сталкером группировки Долг.
                    
            ");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine(@"
                    Спасибо за игру!
            ");
            Thread.Sleep(3000);
            Game_Exit();
        }

        public static void Game_Slashes()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
        }

        public static void Game_Exit()
        {
            /*Console.WriteLine("Остальное в разработке...");
            Console.WriteLine(@"Спасибо за игру.");
            Thread.Sleep(2000);*/
            Console.Clear();
            Console.WriteLine("Приложение закроется автоматически через: 3");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Приложение закроется автоматически через: 2");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Приложение закроется автоматически через: 1");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        /*public static void Game_End_HimikIsDead()
        {
            MainMenu();
        }*/
    }

}
