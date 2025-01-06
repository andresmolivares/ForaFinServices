namespace ForaFinServices.Settings
{
    public class CacheRefreshSettings
    {
        public int RefreshIntervalInMinutes { get; set; }

        public int AbsoluteExpirationInMinutes { get; set; }

        public int SlidingExpirationInMinutes { get; set; }
    }
}
