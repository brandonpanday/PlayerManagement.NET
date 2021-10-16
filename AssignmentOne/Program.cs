using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AssignmentOne
{

    class Program
    {
        static Player[] arr = new Player[40];
        static void Main(string[] args)
        {

            arr[0] = new HockeyPlayer(PlayerType.HockeyPlayer, 101, "Jim Bob", "Team One", 10, 5, 5);
            arr[1] = new HockeyPlayer(PlayerType.HockeyPlayer, 102, "Steven Smith", "Team One", 10, 5, 5);
            arr[2] = new HockeyPlayer(PlayerType.HockeyPlayer, 103, "Mathew Perry", "Team One", 10, 5, 5);

            arr[3] = new BasketballPlayer(PlayerType.BasketballPlayer, 201, "Kyrie Irving", "Team Two", 10, 5, 5);
            arr[4] = new BasketballPlayer(PlayerType.BasketballPlayer, 202, "Kevin Durant", "Team Three", 10, 5, 5);
            arr[5] = new BasketballPlayer(PlayerType.BasketballPlayer, 203, "James Harden", "Team Two", 10, 5, 5);

            arr[6] = new BaseballPlayer(PlayerType.BaseballPlayer, 301, "Sean Pool", "Team Two", 10, 5, 5);
            arr[7] = new BaseballPlayer(PlayerType.BaseballPlayer, 302, "Colin Terry", "Team Three", 10, 5, 5);
            arr[8] = new BaseballPlayer(PlayerType.BaseballPlayer, 303, "Jeff Green", "Team Two", 10, 5, 5);

            bool showMainMenu = true;
            while (showMainMenu)
            {
                showMainMenu = MainMenu();
            }

        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add Player");
            Console.WriteLine("2) Edit Player");
            Console.WriteLine("3) Delete Player ");
            Console.WriteLine("4) View Players");
            Console.WriteLine("5) Search Player");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddMenu();
                    return true;
                case "2":
                    EditMenu();
                    return true;
                case "3":
                    DeleteMenu();
                    return true;
                case "4":
                    ViewMenu();
                    return true;
                case "5":
                    SearchMenu(arr);
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        // Add Players
        public static bool AddMenu()
        {
            bool showAddMenu = true;
            while (showAddMenu)

            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Add Hockey Player");
                Console.WriteLine("2) Add Basketball Player");
                Console.WriteLine("3) Add Baseball Player");
                Console.WriteLine("4) Back to Main Menu");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter Hockey Player information:");
                        // *******
                        GetPlayerInfo(1);
                        // *******

                        return true;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter Basketball Player information:");
                        GetPlayerInfo(2);
                        return true;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter Baseball Player information:");
                        GetPlayerInfo(2);
                        return true;
                    case "4":
                        Console.Clear();
                        return false;
                    default:
                        return true;
                }
            }
            return true;
        }
        public static bool GetPlayerInfo(int type)
        {

            bool showPlayerMenu = true;
            while (showPlayerMenu)
            {
                int x = 0;
                foreach (Player person in arr)
                {
                    if (person != null)
                    {
                        x = x++;
                        x = x + 1;
                    }
                }
                //Console.WriteLine("Enter player id:");
                //string PlayerId = Console.ReadLine();
                int PlayerId = x;
                Console.Write("Enter player name:");
                string PlayerName = Console.ReadLine();
                Console.Write("Enter team name:");
                string TeamName = Console.ReadLine();
                Console.Write("Enter games played:");
                string GamesPlayedString = Console.ReadLine();
                int GamesPlayed = Int16.Parse(GamesPlayedString);

                if (type == 1)
                {

                    Console.Write("Enter assists:");
                    string PlayerAssistsStr = Console.ReadLine();
                    int Assists = Int16.Parse(PlayerAssistsStr);
                    Console.Write("Enter Goals:");
                    string PlayerGoalsStr = Console.ReadLine();
                    int Goals = Int16.Parse(PlayerGoalsStr);
                    arr[x] = new HockeyPlayer(PlayerType.HockeyPlayer, PlayerId, PlayerName, TeamName, GamesPlayed, Assists, Goals);
                    Console.WriteLine("Player submitted.\n");
                    Console.WriteLine(PrintHeader(1));
                    foreach (Player p in arr)
                    {
                        if (p != null)
                            if (p.playertype == PlayerType.HockeyPlayer)
                                Console.WriteLine(p.ToString());
                    }

                }
                if (type == 2)
                {
                    Console.Write("Enter Field Goals:");
                    string FieldGoalsStr = Console.ReadLine();
                    int FieldGoals = Int16.Parse(FieldGoalsStr);
                    Console.Write("Enter Three Pointers:");
                    string ThreePointersStr = Console.ReadLine();
                    int ThreePointers = Int16.Parse(ThreePointersStr);
                    arr[x] = new BasketballPlayer(PlayerType.BasketballPlayer, PlayerId, PlayerName, TeamName, GamesPlayed, FieldGoals, ThreePointers);
                    Console.WriteLine("Player submitted.\n");
                    Console.WriteLine(PrintHeader(2));
                    foreach (Player p in arr)
                    {
                        if (p != null)
                            if (p.playertype == PlayerType.BasketballPlayer)
                                Console.WriteLine(p.ToString());
                    }
                }
                if (type == 3)
                {
                    Console.Write("Enter Runs:");
                    string RunsStr = Console.ReadLine();
                    int Runs = Int16.Parse(RunsStr);
                    Console.Write("Enter Home Runs:");
                    string HomeRunsStr = Console.ReadLine();
                    int HomeRuns = Int16.Parse(HomeRunsStr);
                    arr[x] = new BaseballPlayer(PlayerType.BaseballPlayer, PlayerId, PlayerName, TeamName, GamesPlayed, Runs, HomeRuns);
                    Console.WriteLine("Player submitted.\n");
                    Console.WriteLine(PrintHeader(3));
                    foreach (Player p in arr)
                    {
                        if (p != null)
                            if (p.playertype == PlayerType.BaseballPlayer)
                                Console.WriteLine(p.ToString());
                    }
                }


                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();


                showPlayerMenu = false;
            }

            
            return true;
        }
        // Edit Players
        public static bool EditMenu()
        {

            bool showEditMenu = true;
            while (showEditMenu)

            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Edit Hockey Player");
                Console.WriteLine("2) Edit Basketball Player");
                Console.WriteLine("3) Edit Baseball Player");
                Console.WriteLine("4) Back to Main Menu");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        PlayerType h = PlayerType.HockeyPlayer;
                        Console.Clear();
                        EditPlayerInfo(h);
                        return true;
                    case "2":
                        PlayerType b = PlayerType.BasketballPlayer;
                        Console.Clear();
                        EditPlayerInfo(b);
                        return true;
                    case "3":
                        PlayerType bb = PlayerType.BaseballPlayer;
                        Console.Clear();
                        EditPlayerInfo(bb);
                        return true;
                    default:
                        return true;
                }

            }
            return true;

        }
        public static bool EditPlayerInfo(PlayerType type)
        {
            Console.Clear();
            Console.WriteLine("Players");
            foreach (Player p in arr)
            {
                if (p != null)
                    if (p.playertype == type)
                        Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nType exit to return to previous screen.");
            Console.Write("Enter player id:");
            String inputString = Console.ReadLine();
            if (inputString == "exit")
            {
                return true;
            }
            else
            {
                int input = Int16.Parse(inputString);
                foreach (Player p in arr)
                {
                    if (p != null)
                        if (p.playertype == type)
                            if (input == p.PlayerId)
                            {
                                Console.Write("\nNew Player Name:");
                                p.PlayerName = Console.ReadLine();
                                Console.Write("New Team Name:");
                                p.TeamName = Console.ReadLine();
                                Console.Write("New Games Played:");
                                string GamesPlayedString = Console.ReadLine();
                                Console.WriteLine("\n");
                                int GamesPlayed = Int16.Parse(GamesPlayedString);
                                p.GamesPlayed = GamesPlayed;

                                if (type == PlayerType.HockeyPlayer)
                                    Console.WriteLine(PrintHeader(1));
                                if (type == PlayerType.BasketballPlayer)
                                    Console.WriteLine(PrintHeader(2));
                                if (type == PlayerType.BaseballPlayer)
                                    Console.WriteLine(PrintHeader(3));

                                foreach (Player n in arr)
                                {
                                    if (n != null)
                                        if (n.playertype == type)
                                            Console.WriteLine(n.ToString());
                                }
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadLine();
                            }
                }
                return true;
            }
            

        }

        public static bool ViewMenu()
        {

            bool showViewMenu = true;
            while (showViewMenu)

            {
                Console.WriteLine("\n");
                Console.WriteLine(PrintHeader(1));
                foreach (Player p in arr)
                {
                    if (p != null)
                        if (p.playertype == PlayerType.HockeyPlayer)
                            Console.WriteLine(p.ToString());
                }
                Console.WriteLine("\n");
                Console.WriteLine(PrintHeader(2));
                foreach (Player p in arr)
                {
                    if (p != null)
                        if (p.playertype == PlayerType.BasketballPlayer)
                            Console.WriteLine(p.ToString());
                }
                Console.WriteLine("\n");
                Console.WriteLine(PrintHeader(3));
                foreach (Player p in arr)
                {
                    if (p != null)
                        if (p.playertype == PlayerType.BaseballPlayer)
                            Console.WriteLine(p.ToString());
                }
                Console.WriteLine("\n");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                

                showViewMenu = false;


            }

            
            return true;

        }

        public static void SearchMenu(Player[] array)
        {

            Console.Write("Enter players name:");
            string name = Console.ReadLine();

            foreach (Player person in array)
            {
                if (person != null)
                {
                    if (person.PlayerName.Contains(name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(person.ToString());
                    }

                }
                    
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        // Delete Menu
        public static bool DeleteMenu()
        {

            bool showDeleteMenu = true;
            while (showDeleteMenu)

            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Delete Hockey Player");
                Console.WriteLine("2) Delete Basketball Player");
                Console.WriteLine("3) Delete Baseball Player");
                Console.WriteLine("4) Back to Main Menu");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        DeletePlayer(arr, 1);
                        return true;
                    case "2":
                        Console.Clear();
                        DeletePlayer(arr, 2);
                        return true;
                    case "3":
                        Console.Clear();
                        DeletePlayer(arr, 3);
                        return true;
                    default:
                        return true;
                }

            }
            return true;

        }
        public static void DeletePlayer(Player[] arr, int n)
        {
            if (n == 1)
            {
                Console.WriteLine(PrintHeader(1));
                foreach (Player p in arr)
                {
                    if (p != null)
                        if (p.playertype == PlayerType.HockeyPlayer)
                            Console.WriteLine(p.ToString());
                }
            }
            else if (n == 2)
            {
                Console.WriteLine(PrintHeader(2));
                foreach (Player p in arr)
                {
                    if (p != null)
                        if (p.playertype == PlayerType.BasketballPlayer)
                            Console.WriteLine(p.ToString());
                }
            }

            else if (n == 3)
            {
                Console.WriteLine(PrintHeader(3));
                foreach (Player p in arr)
                {
                    if (p != null)
                        if (p.playertype == PlayerType.BaseballPlayer)
                            Console.WriteLine(p.ToString());
                }
            }

            Console.WriteLine("Enter player id to delete:");
            string inputString = Console.ReadLine();

            int input = Int16.Parse(inputString);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();


        }


        public static string PrintHeader(int n)
        {
            string head;
            switch (n)
            {
                case 1:
                    head = string.Format("{0,18} {1,12} {2, 12} {3,12} {4,12} {5,12} {6,12} {7,12}",
                    "Player Type", "PlayerId", "Player Name", "Team Name", "Games Played", "Assists", "Goals", "Points");
                    return head;
                case 2:
                    head = string.Format("{0,18} {1,12} {2, 12} {3,12} {4,12} {5,12} {6,12} {7,12}",
                       "Player Type", "PlayerId", "Player Name", "Team Name", "Games Played", "FieldGoals", "ThreePointers", "Points");
                    return head;
                case 3:
                    head = string.Format("{0,18} {1,12} {2, 12} {3,12} {4,12} {5,12} {6,12} {7,12}",
                       "Player Type", "PlayerId", "Player Name", "Team Name", "Games Played", "Runs", "HomeRuns", "Points");
                    return head;
                default:
                    return "";
            }

        }
        
    }


}


