using System;
using System.Collections.Generic;

namespace Linca_David_Lab4_MasterEB.Models
{
    public class DashboardViewModel
    {
        public int TotalPredictions { get; set; }
        public List<PaymentTypeStat> PaymentTypeStats { get; set; } = new();
        public List<PriceBucketStat> PriceBuckets { get; set; } = new();
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}