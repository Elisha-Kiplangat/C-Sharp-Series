Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

int employeeLevel = 200;
string employeeName = "John Doe";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Associate";
        break;
    case 300:
        title = "Senior Associate";
        break;
    case 400:
        title = "Manager";
        break;
    case 500:
        title = "Senior Manager";   
        break;
    case 600:
        title = "Director";
        break;
    default:
        title = "Unknown";
        break;
}

Console.WriteLine($"{employeeName} is an {title}.");

string names = "01-MN-L";
string[] product = sku.Split('-'); 

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweatshirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweatpants";
        break;
    default:
        type = "other";
        break;
}

switch (product[1]) {
    case "MN":
        color = "Maroon";
        break;
    case "BL":
        color = "Black";
        break;
    default:
        color = "white";
        break;
}

switch (product[2]) {
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "one size fits all";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");