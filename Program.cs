
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
