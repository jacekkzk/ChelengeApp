var name = "Ewa";
var sex = "Kobieta";
var age = 29;

if (name == "Ewa" && age == 29)
{
    Console.WriteLine("Ewa lat 29");
}

else if (sex == "Kobieta" && age < 29)
{
    Console.WriteLine("Ewa, ponizej 29 lat");
}

else if (sex == "Meszczyzna" && age < 18)
{
    Console.WriteLine("Niepelnoletni Meszczyzna");
}