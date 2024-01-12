namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Hero mainHero = new Hero(1, new City(), new Weapon());

            HeroClone clone = new HeroClone(mainHero);
        }

    }

    public class Hero
    {
        public int Level;
        public City City;
        public Weapon Weapon;

        public Hero(int level, City city, Weapon weapon) 
        { 
            Level = level;
            City = city;
            Weapon = weapon;
        }
        public Hero(Hero hero)
        {

        }
    }
    public class HeroClone
    {
        public int Level;
        public Weapon Weapon;

        public HeroClone(Hero hero)
        {
            Level =hero.Level;
            Weapon = hero.Weapon;
        }
    }

    public struct City { }
    public struct Weapon { }
}