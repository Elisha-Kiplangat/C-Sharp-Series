Random random = new Random();

int coin = random.Next(1, 2);

if (coin == 1) {
    Console.WriteLine("You got a head");
}
else {
    Console.WriteLine("You got a tail");
}

// 
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

// boolean
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}


// Variable Scope
bool isEven = true;
int num = 4;

if (isEven == true) {
    num += 2;
    Console.WriteLine(num);
}
else {
    num += 1;
    Console.WriteLine(num);
};

Console.WriteLine(num);

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");