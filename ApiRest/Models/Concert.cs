namespace ApiRest.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public required string name { get; set; }
        public required string town { get; set; }
        public required string state { get; set; }
        public required DateOnly date { get; set; }
    }
}
