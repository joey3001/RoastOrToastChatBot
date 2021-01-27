using System.Collections.Generic;

namespace ConsultingBot.Model
{
    public enum Intent
    {
        Unknown,
        Roast,
        Toast,
    }

    public class ConsultingRequestDetails
    {
        public Intent intent { get; set; } = Intent.Unknown;

    }
}
