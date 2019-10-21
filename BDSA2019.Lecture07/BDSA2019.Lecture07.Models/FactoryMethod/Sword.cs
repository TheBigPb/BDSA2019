namespace BDSA2019.Lecture07.Models.FactoryMethod
{
    public class Sword : IWeapon
    {
        public string Name => nameof(Sword);

        public int Damage => 32;

        public int Range => 0;
    }
}
