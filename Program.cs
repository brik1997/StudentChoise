string[] jobList =
{
    "Electrician",
    "Roofer",
    "Plumber",
    "Carpenter",
    "Welder",
    "Woodworker",
    "Painter",
    "HVAC Technician",
    "Construction Laborer",
    "Landscaper"
};

Console.WriteLine("Blue Collar Job Choice");
Console.WriteLine();
Console.WriteLine("Available jobs:");
for (int i = 0; i < jobList.Length; i++)
{
    Console.WriteLine((i + 1) + ". " + jobList[i]);
}
Console.WriteLine();
Console.WriteLine("Please note: your choices are ranked by preference. Your first choice has the highest priority. You cannot select the same job as both your first and second choice, so these must be different. For your third choice, you may select the same job as your first choice again.");
Console.WriteLine();

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Please enter your first choice:");
string choice1 = Console.ReadLine();

Console.WriteLine("Please enter your second choice:");
string choice2 = Console.ReadLine();

Console.WriteLine("Please enter your third choice:");
string choice3 = Console.ReadLine();

Console.WriteLine();

bool choice1IsValidJob = jobList.Contains(choice1, StringComparer.OrdinalIgnoreCase);
bool choice2IsValidJob = jobList.Contains(choice2, StringComparer.OrdinalIgnoreCase);
bool choice3IsValidJob = jobList.Contains(choice3, StringComparer.OrdinalIgnoreCase);

if (!choice1IsValidJob)
{
    Console.WriteLine("Your first choice is not valid. Please choose a job from the list.");
}

if (!choice2IsValidJob)
{
    Console.WriteLine("Your second choice is not valid. Please choose a job from the list.");
}

if (!choice3IsValidJob)
{
    Console.WriteLine("Your third choice is not valid. Please choose a job from the list.");
}

bool choice1And2AreDifferent = !string.Equals(choice1, choice2, StringComparison.OrdinalIgnoreCase);

if (choice1IsValidJob && choice2IsValidJob && !choice1And2AreDifferent)
{
    Console.WriteLine("Your choices are not valid. Your first and second choice must be different.");
}

if (choice1IsValidJob && choice2IsValidJob && choice3IsValidJob && choice1And2AreDifferent)
{
    Console.WriteLine("Your choices are valid.");
    Console.WriteLine();
    Console.WriteLine("Student: " + name);
    Console.WriteLine("First choice: " + choice1);
    Console.WriteLine("Second choice: " + choice2);
    Console.WriteLine("Third choice: " + choice3);
}
