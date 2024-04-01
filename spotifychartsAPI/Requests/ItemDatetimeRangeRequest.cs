namespace spotifychartsAPI.Requests
{
    public class ItemDatetimeRangeRequest
    {
        public string Item { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
