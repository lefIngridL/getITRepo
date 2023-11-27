namespace PP_virtualPet_med_INE;



    internal class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Species { get; private set; }

        public Pet(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }
    }
