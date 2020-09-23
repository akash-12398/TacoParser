namespace LoggingKata
{
    class TacoBell : ITrackable
    {
        public TacoBell()
        {
        }

        public string Name { get; set; }
        public Point Location { get; set; }
    }
}