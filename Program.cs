
static double CirkelOmkrets(double a){
    double fan = a * 2 * 3.14;
    return fan;
}

static double CirkelArea(double b){
    double piss = 3.14 * b * b;
    return piss;
}

double radie=2.4;
Console.WriteLine("Cirkelns omkrets: "+ CirkelOmkrets(radie));
Console.WriteLine("Cirkelns area: "+ CirkelArea(radie));


Console.WriteLine("ge mig tre tal");
Console.WriteLine("tal 1:");
    int tal1 = int.Parse(Console.ReadLine());
Console.WriteLine("tal 2:");
    int tal2 = int.Parse(Console.ReadLine());
Console.WriteLine("tal 3:");
    int tal3 = int.Parse(Console.ReadLine());


Console.WriteLine(medelvärde(tal1, tal2, tal3));


static double medelvärde(double a, double b, double c){
    double svar = a + b + c;
    double ag = svar / 3;
    return ag;
}