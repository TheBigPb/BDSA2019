namespace BDSA2019.Lecture08.Entities
{
    public class SuperheroPower
    {
        public int SuperheroId { get; set; }

        public Superhero Superhero { get; set; }

        public int PowerId { get; set; }
        
        public Power Power { get; set; }
    }
}
