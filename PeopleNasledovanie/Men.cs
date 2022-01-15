using System;
namespace PeopleNasledovanie
{
    public abstract class Men:People
    {
        abstract public void GiveReproduction(int number);
        abstract public void Beard(bool yes);
        
    }
}
