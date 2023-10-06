using System;
using Helpers;

namespace GU1_Zoo
{
	public class csAfricanZoo : csZoo
	{
        public override int kgMeat
        {
            get
            {
                int _kgMeat = 0;
                foreach (var item in ListOfAnimal)
                {
                    if (item.Kind == enAnimalKind.Aligator)
                    {
                        _kgMeat += 10;
                    }
                    if (item.Kind == enAnimalKind.Lion)
                    {
                        _kgMeat += 5;
                    }
                }
                return _kgMeat;
            }
        }

        public csAfricanZoo()
		{
            Name = "African Zoo";
            var rnd = new csSeedGenerator();
            for (enAnimalKind kind = enAnimalKind.Aligator; kind <= enAnimalKind.Monkey; kind++)
            {
                var count = rnd.Next(0, 6);
                for (int i = 0; i < count; i++)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind });
                }
            }
        }
	}

    public class csEuropeanZoo : csZoo
    {
        public override int nrWolfs
        {
            get
            {
                int _nrWolfs = 0;
                foreach (var item in ListOfAnimal)
                {
                    if (item.Kind == enAnimalKind.Wolf)
                    {
                        _nrWolfs++;
                    }
                }
                return _nrWolfs;
            }
        }

        public csEuropeanZoo()
        {
            Name = "European Zoo";
            var rnd = new csSeedGenerator();
            for (enAnimalKind kind = enAnimalKind.Moose; kind <= enAnimalKind.Fox; kind++)
            {
                var count = rnd.Next(1, 11);
                for (int i = 0; i < count; i++)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind });
                }
            }
        }
    }

    public class csBirdZoo : csZoo
    {
        public override int nrParrots
        {
            get
            {
                int _nrParrot = 0;
                foreach (var item in ListOfAnimal)
                {
                    if (item.Kind == enAnimalKind.Parrot)
                    {
                        _nrParrot++;
                    }
                }
                return _nrParrot;
            }
        }

        public csBirdZoo()
        {
            Name = "Bird Zoo";
            var rnd = new csSeedGenerator();
            for (enAnimalKind kind = enAnimalKind.Eagle; kind <= enAnimalKind.Parrot; kind++)
            {
                var count = rnd.Next(5, 11);
                for (int i = 0; i < count; i++)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind });
                }
            }
        }
    }
}

