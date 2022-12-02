Console.WriteLine("Count them Calories");

int elfWithMostCalories = 1;
int mostCalories = 0;

int currentCalories = 0;
int currentElf = 1;

foreach (string line in File.ReadLines("input.txt"))
{
    if (string.IsNullOrWhiteSpace(line))
    {
        if (currentCalories > mostCalories)
        {
            elfWithMostCalories = currentElf;
            mostCalories = currentCalories;
        }

        currentElf++;
        currentCalories = 0;
        continue;
    }

    currentCalories += int.Parse(line);
}

Console.WriteLine($"Elf {elfWithMostCalories} is the food goblin.");
Console.WriteLine($"The goon has {mostCalories} calories.");