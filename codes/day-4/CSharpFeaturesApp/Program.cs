//int x = null;
//Cannot convert null to 'int' because it is a non-nullable value type

//nullable value type
//x is of type Nullable<int>, NOT int

//Nullable<int> x = null;
// Nullable<decimal> y = null;
// Nullable<bool> isTrue = null;

// bool status = false;
// char ch = 'a';

// string name = null;

// Nullable<int> nullableInt = 123;
int? nullableInt = 123;

if (nullableInt.HasValue)
    //Console.WriteLine($"{nullableInt.Value}");
    Console.WriteLine($"{nullableInt}");
else
    Console.WriteLine($"no value");


