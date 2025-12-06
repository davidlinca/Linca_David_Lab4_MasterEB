namespace Linca_David_Lab4_MasterEB.Models
{
    public class PriceBucketStat
    {
        public string Label { get; set; } = string.Empty; // ex. "0-10", "10-20"
        public int Count { get; set; }
    }
}
