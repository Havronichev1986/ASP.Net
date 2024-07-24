namespace WebApplication1.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
    }
    public class AnimalGenerator : IAnimalGenerator
    {
        private readonly string[] _Name = { "cat", "dog", "owl", "hamster" };
        private readonly string[] _Sound = { "meow", "woof", "hoo-hoo", "*squek*" };
        public Animal createNewAnimal()
        {
            string animal, sound;
            var random = new Random();
            var Animalindex = random.Next(4);
            animal = _Name[Animalindex];
            sound = _Sound[Animalindex];
            return new Animal { Name = animal, Sound = sound };
        }

        public Animal addNewAnimal()
        {
            string animal, sound;
            var random = new Random();
            var Animalindex = random.Next(4);
            animal = _Name[Animalindex];
            sound = _Sound[Animalindex];
            File.WriteAllText(animal, animal + sound);
            File.WriteAllText(animal+".txt", animal + sound);
            File.WriteAllText(animal+".pdf", animal + sound);
            return new Animal { Name = animal, Sound = sound };
        }
        public Animal openNewAnimal()
        {
            if (File.Exists("hamster.txt"))
            {
                string sound = File.ReadAllText("hamster.txt");
                return new Animal { Name = sound, Sound = "" };
            }
            else if (File.Exists("hamster.pdf"))
            {
                string sound = File.ReadAllText("hamster.pdf");
                return new Animal { Name = sound, Sound = "" };
            }
            else if (File.Exists("hamster"))
            {
                string sound = File.ReadAllText("hamster");
                return new Animal { Name = sound, Sound = "" };
            }
            else
            {
                return new Animal { Name = "*Empty*", Sound = "*Empty" };
            }
        }
    }
    public interface IAnimalGenerator
    {
        Animal createNewAnimal();
        Animal addNewAnimal();
        Animal openNewAnimal();
    }
}
