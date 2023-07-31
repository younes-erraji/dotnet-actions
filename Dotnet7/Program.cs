using static System.Console;

/*
int age = 22;
if (age is > 18 and < 60)
{
    WriteLine("age is > 18 and < 60");
}

string name = "  ";
if (string.IsNullOrWhiteSpace(name))
{
    WriteLine("string.IsNullOrWhiteSpace(name)");
}

string G = age > 18 ? "Adult" : age > 10 ? "Young" : "Child";
WriteLine(G);

var numbers = Enumerable.Range(0, 10).Select((x, index) => $"{index} => {x}");

Write("Number from Null: ");
int.TryParse(null, out int number);
WriteLine(number);

var today = DateTime.Now.DayOfYear;
var someday = DateTime.Now.AddDays(40).DayOfYear;
WriteLine(today);
WriteLine(someday);
WriteLine(someday - today);

WriteLine("DateTIME Comparisation:");
WriteLine(DateTime.Now >= DateTime.Now); // false
WriteLine(DateTime.Now == DateTime.Now); // false
WriteLine(DateTime.Now > DateTime.Now); // false
WriteLine(DateTime.Now.AddDays(2) > DateTime.Now.AddHours(5)); // true
WriteLine(DateTime.Now.AddDays(2) == DateTime.Now.AddHours(48)); // false

WriteLine("DateTIME Comparisation:");
var date = DateTime.Now;
WriteLine(date >= date); // true
WriteLine(date == date); // true
WriteLine(date > date); // false
WriteLine(date.AddDays(2) > date.AddHours(5)); // true
WriteLine(date.AddDays(2) == date.AddHours(48)); // true

WriteLine("string.IsNullOrEmpty()");
WriteLine(string.IsNullOrEmpty(null)); // True
WriteLine(string.IsNullOrEmpty("")); // True
WriteLine(string.IsNullOrEmpty(" ")); // False

WriteLine("string.IsNullOrWhiteSpace(null)");
WriteLine(string.IsNullOrWhiteSpace(null)); // True
WriteLine(string.IsNullOrWhiteSpace("")); // True
WriteLine(string.IsNullOrWhiteSpace("  ")); // True

WriteLine("################################");
WriteLine(DateTime.Now.ToFileTime());
WriteLine(DateTime.Now.ToFileTime());
WriteLine(DateTime.Now.ToFileTime());
WriteLine(DateTime.Now.ToFileTime());

WriteLine("################################");
WriteLine(DateOnly.FromDateTime(DateTime.Now).ToString("dd/MM/yyyy"));

WriteLine("################################");
WriteLine(null ?? "Younes");
WriteLine("################################");

var order = new bool[] { false, false, true, true, true };
order.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
*/
/*
static async Task BackgroundProcess()
{
    WriteLine("Start Background Process");
    await Task.Run(() =>
    {
        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(1000);
            WriteLine("I => " + i);
        }
    });

    WriteLine("Start Background Process");
}

WriteLine("Main Start");

BackgroundProcess();

WriteLine("Main End");
*/
/*
int normalNumber = 3;
int? nullableNumber = 3;

WriteLine(normalNumber == nullableNumber);
WriteLine(normalNumber == (int)nullableNumber);

WriteLine("##################################");

int? number = null;
WriteLine(number.ToString());

int.TryParse(number.ToString(), out int convertedNumber);
WriteLine(convertedNumber);

int i = (int)number;
WriteLine(i);
*/
/*
List<Person> people = new List<Person> {
    new Person { Id = 1, Name = "Younes" },
    new Person { Id = 2, Name = "Safae" },
    new Person { Id = 1, Name = "Ilham" },
    new Person { Id = 1, Name = "Youssef" },
    new Person { Id = 3, Name = "Malika" },
};

foreach (Person person in people.DistinctBy(x => x.Id))
{
    WriteLine(person.Name);
}
*/
/*
int? number = null;
bool? active = null;
// WriteLine((bool)active); // Throws an Error
// WriteLine((int)number); // Throws an Error
*/

ReadKey();

/*
public class Program
{
    public static int Main()
    {
        WriteLine("Main Start");

        var t = new Thread(() =>
        {
            BackgroundProcess();
        });

        t.Start();

        WriteLine("Main Stop");

        return 1;
    }

    static async Task BackgroundProcess()
    {
        WriteLine("Start Background Process");
        await Task.Run(() =>
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1000);
                WriteLine("I => " + i);
            }
        });

        WriteLine("Start Background Process");
    }
}
*/
