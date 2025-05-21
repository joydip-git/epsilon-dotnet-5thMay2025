TaskDel<string> printDel = name => Console.WriteLine(name);
CalculationDel<int, int> addDel = (x, y) => x + y;
CalculationDel<int,int,int> subDel = (x, y) => x - y;
CalculationDel<int, long, long> multiDel = (x, y) => x * y;

//declare a delegate which can be used to invoke any method which accepts ONLY one argument of any type and returns nothing (void) where the types are decided during the usage
delegate void TaskDel<in T>(T value);

//declare a delegate which can be used to invoke any method which accepts ONLY two arguments of any types and those types are similar and returns any type where the types are decided during the usage
delegate TResult CalculationDel<in TInput, out TResult>(TInput a, TInput b);

//declare a delegate which can be used to invoke any method which accepts ONLY two arguments of any types and those types NEED NOT BE similar and returns any type where the types are decided during the usage
delegate TResult CalculationDel<in T1, in T2, out TResult>(T1 a, T2 b);//T1==T2 or T!= T2

//Note: in the list of type parameters for delegate all "in" (input) type parameters should be declared first and then the "out" (output) type parameter




