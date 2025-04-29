Console.WriteLine("### Nullable Types ##\n");
//Nullable<T><nome>=null;   Nullable<bool>b=null;

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

//Para simplificar pode se utilizar o operador "?" EX: Int? i = null

int? t = null;
double? g = null;
bool? v = null;

Console.WriteLine(t);
Console.WriteLine(g);
Console.WriteLine(v);

// Utilizar o operador "??" para atribuir um tipo anulável a um tipo não anulável

int? a = null;
int e = a  ??  0;
Console.WriteLine(e);

Console.ReadKey();