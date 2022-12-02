Console.WriteLine("Count them Calories");

int[] calories = new int[3];

int currentCalories = 0;

foreach (string line in File.ReadLines("input.txt"))
{
    if (string.IsNullOrWhiteSpace(line))
    {
        int min = calories.Min();
        if (currentCalories > min)
        {
            calories[Array.IndexOf(calories, min)] = currentCalories;
        }

        currentCalories = 0;
        continue;
    }

    currentCalories += int.Parse(line);
}

Console.WriteLine($"Total calories of top 3 elves: {calories.Sum()}");
foreach (int cal in calories)
{
    Console.WriteLine(cal);
}