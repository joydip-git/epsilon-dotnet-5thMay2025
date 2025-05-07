int value = 10;

//string interpolation => $"{data}"
Console.WriteLine($"Value in prefix: {++value}");
Console.WriteLine("Value in postfix: " + value++);
Console.WriteLine($"Current value: {value}");

int myData = 5;
Console.WriteLine($"Unary plus: {+myData}");
Console.WriteLine($"Unary minus: {-myData}");

int simpleValue = 10;
simpleValue += 5; // simpleValue = simpleValue + 5
Console.WriteLine($"Simple value: {simpleValue}");

simpleValue -= 5; // simpleValue = simpleValue - 5
Console.WriteLine($"Simple value: {simpleValue}");

simpleValue *= 5; // simpleValue = simpleValue * 5 
Console.WriteLine($"Simple value: {simpleValue}");

simpleValue /= 5; // simpleValue = simpleValue / 5
Console.WriteLine($"Simple value: {simpleValue}");

simpleValue %= 5; // simpleValue = simpleValue % 5
Console.WriteLine($"Simple value: {simpleValue}");

//Binray aritmetic operators are left-associative, i.e.  the operators with same precedence level are evaluated from left to right.
Console.WriteLine(2 + 2 * 2);//6
//Use () to change the order of the velaution enforced by the operator precendence and associativity
Console.WriteLine((2 + 2) * 2);//8


bool test = true;
test &= false; // test = test & false
Console.WriteLine($"Test value: {test}");

test |= true; // test = test | true
Console.WriteLine($"Test value: {test}");

test ^= false; // test = test ^ false
Console.WriteLine($"Test value: {test}");