public class UserInterface
{
    private List<Goal> _goalList;
    private int _totalPoints;
    private string _rank;

    public UserInterface()
    {
        _goalList = new List<Goal>();
        _totalPoints = 0;
        _rank = "Skill-Issue Extraordinaire";
    }


    public void Menu()
    {
        bool loop = true;

        while (loop == true)
        {
            SetRank(_totalPoints);
            Console.WriteLine($"\nYou have {_totalPoints} points!\nYou rank is a {_rank}.\n\nMenu Options:\n1. Create New Goal\n2. View Current Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n\nSelect a choice from the menu:");
            string userInput = Console.ReadLine();
            int userMenuChoice = int.Parse(userInput);

            if (userMenuChoice == 1)
            {
                Console.Clear();
                NewGoal();
            }
            else if (userMenuChoice == 2)
            {
                Console.Clear();
                DisplayGoals();
            }
            else if (userMenuChoice == 3)
            {
                Console.Clear();
                Save();
            }
            else if (userMenuChoice == 4)
            {
                Console.Clear();
                Load();
            }
            else if (userMenuChoice == 5)
            {
                Console.Clear();
                RecordEvent();
            }
            else if (userMenuChoice == 6)
            {
                Console.Clear();
                loop = false;
                Console.WriteLine("\nSee you next time!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInvalid Input: Hit enter to continue.");
                Console.ReadLine();
            }

            Console.Clear();
        }
    }
    public void DisplayGoals()
    {
        string complete;
        int counter = 1;

        Console.WriteLine("\nYour goals are:");
        foreach (Goal goal in _goalList)
        {
            if (goal.IsComplete() == true)
            {
                complete = "[✓]";
            }
            else
            {
                complete = "[ ]";
            }

            Console.WriteLine($"{counter}.  {complete}  {goal.getName()} ({goal.getDescription()})");

            counter = counter + 1;
        }
        Console.WriteLine("\nHit enter to continue.");
        Console.ReadLine();
    }
    public void RecordEvent()
    {
        bool loop = true;

        while (loop == true)
        {
            int counter = 1;

            Console.WriteLine("\nYour goals are:");
            foreach (Goal selectedGoal in _goalList)
            {
                Console.WriteLine($"{counter}. {selectedGoal.getName()}");
                counter = counter + 1;
            }
            Console.WriteLine("\nWhich goal did you accomplish?");

            string userInput = Console.ReadLine();
            int goalNumber = int.Parse(userInput);
            goalNumber = goalNumber - 1;

            if (goalNumber > -1 && goalNumber < _goalList.Count)
            {
                Goal goal = _goalList[goalNumber];
                goal.MarkAsDone();
                AddToTotalPoints(goal.GetPoints());

                loop = false;
            }
            else
            {
                Console.WriteLine("\nIvalid goal type. Hit enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }


        }
        Console.WriteLine("\nHit enter to continue.");
        Console.ReadLine();
    }
    public List<Goal> GetGoalList()
    {
        return _goalList;
    }
    public void NewGoal()
    {
        bool loop = true;

        while (loop == true)
        {
            Console.WriteLine("\nThe types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n\nWhich type of goal would you like to create?");
            string userInput = Console.ReadLine();
            int goalType = int.Parse(userInput);

            if (goalType == 1)
            {
                Console.WriteLine("\nWhat is the name of your goal?");
                string goalName = Console.ReadLine();
                Console.WriteLine("\nWhat is a small description of your goal?");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("\nHow many points is your goal worth?");
                userInput = Console.ReadLine();
                int goalPoints = int.Parse(userInput);

                SimpleGoal simpleGoal = new SimpleGoal($"{goalName}", $"{goalDescription}", goalPoints);
                _goalList.Add(simpleGoal);

                Console.WriteLine("\nGoal created!");
                loop = false;
            }
            else if (goalType == 2)
            {
                Console.WriteLine("\nWhat is the name of your goal?");
                string goalName = Console.ReadLine();
                Console.WriteLine("\nWhat is a small description of your goal?");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("\nHow many points is your goal worth?");
                userInput = Console.ReadLine();
                int goalPoints = int.Parse(userInput);

                EternalGoal eternalGoal = new EternalGoal($"{goalName}", $"{goalDescription}", goalPoints);
                _goalList.Add(eternalGoal);

                Console.WriteLine("\nGoal created!");
                loop = false;
            }
            else if (goalType == 3)
            {
                Console.WriteLine("\nWhat is the name of your goal?");
                string goalName = Console.ReadLine();
                Console.WriteLine("\nWhat is a small description of your goal?");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("\nHow many points is your goal worth?");
                userInput = Console.ReadLine();
                int goalPoints = int.Parse(userInput);
                Console.WriteLine("\nHow many times does your goal need to be recorded until it is complete?");
                userInput = Console.ReadLine();
                int goalTimesNeeded = int.Parse(userInput);
                Console.WriteLine("\nHow many bonus points should you get if you complete your goal?");
                userInput = Console.ReadLine();
                int goalBonus = int.Parse(userInput);

                ChecklistGoal checklistGoal = new ChecklistGoal($"{goalName}", $"{goalDescription}", goalPoints, goalTimesNeeded, goalBonus);
                _goalList.Add(checklistGoal);

                Console.WriteLine("\nGoal created!");
                loop = false;
            }
            else
            {
                Console.WriteLine("\nInvalid goal type. Re-enter your goal details.\n");
            }

            Console.WriteLine("\nHit enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public void AddToTotalPoints(int points)
    {
        _totalPoints = _totalPoints + points;
        Console.WriteLine($"\nCongrats, you have earned {points} points!\nYou now have {_totalPoints} points in total!");
    }

    public void SetRank(int points)
    {
        if (points > 999)
        {
            _rank = "The Almighty Supreme Leader of the Galactic Empire";
        }
        else if (points > 599)
        {
            _rank = "Super Unicorn Ninja";
        }
        else if (points > 499)
        {
            _rank = "Cool Homie-Buddy";
        }
        else if (points > 399)
        {
            _rank = "Now we're gettin' somewhere lol";
        }
        else if (points > 299)
        {
            _rank = "Okay-ish Human";
        }
        else if (points > 199)
        {
            _rank = "Mid-Tier Person";
        }
        else if (points > 99)
        {
            _rank = "Below-Average Joe";
        }
        else if (points > -1)
        {
            _rank = "Skill-Issue Extraordinaire";
        }
        else
        {
            _rank = "eh?";
        }
    }
    public void Save()
    {
        Console.WriteLine("\nEnter the name for your Goal-Tracker file (include \".txt\" at the end of the file name): ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("0" + "," + $"{_totalPoints}" + "," + $"{_rank}");

            foreach (Goal goal in _goalList)
            {
                if (goal is SimpleGoal)
                {
                    SimpleGoal simpleGoal = (SimpleGoal)goal;

                    outputFile.WriteLine("1" + "," + $"{simpleGoal.getName()}" + "," + $"{simpleGoal.getDescription()}" + "," + $"{simpleGoal.GetPoints()}" + "," + $"{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal)
                {
                    EternalGoal eternalGoal = (EternalGoal)goal;

                    outputFile.WriteLine("2" + "," + $"{eternalGoal.getName()}" + "," + $"{eternalGoal.getDescription()}" + "," + $"{eternalGoal.GetPoints()}" + "," + $"{eternalGoal.IsComplete()}" + "," + $"{eternalGoal.GetTimesCompleted()}");
                }
                else if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;

                    outputFile.WriteLine("3" + "," + $"{checklistGoal.getName()}" + "," + $"{checklistGoal.getDescription()}" + "," + $"{checklistGoal.GetPoints()}" + "," + $"{checklistGoal.IsComplete()}" + "," + $"{checklistGoal.GetNumberNeededToComplete()}" + "," + $"{checklistGoal.GetNumberCurrentlyComplete()}" + "," + $"{checklistGoal.GetBonusPoints()}");
                }
            }
        }

        Console.WriteLine("\nYour file has been saved. Press enter to continue.");
        Console.ReadLine();
    }
    public void Load()
    {
        bool loop = true;

        while (loop == true)
        {
            Console.WriteLine("\nEnter the name for your Goal-Tracker file (include \".txt\" at the end of the file name, or type \"quit\" to return to the menu): ");
            string fileName = Console.ReadLine();

            try
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    if (parts[0] == "0")
                    {
                        _totalPoints = int.Parse(parts[1]);
                        _rank = parts[2];
                    }
                    else if (parts[0] == "1")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));

                        _goalList.Add(simpleGoal);
                    }
                    else if (parts[0] == "2")
                    {
                        EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]));

                        _goalList.Add(eternalGoal);
                    }
                    else if (parts[0] == "3")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));

                        _goalList.Add(checklistGoal);
                    }
                }

                loop = false;
            }
            catch
            {
                if (fileName == "quit")
                {
                    loop = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid file name. Hit enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
    }
}