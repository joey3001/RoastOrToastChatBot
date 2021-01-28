
namespace RoastOrToastBot.Model
{
    public enum Intent
    {
        Unknown,
        Roast,
        Toast,
    }

    public class RoastOrToastRequestDetails
    {
        public Intent intent { get; set; } = Intent.Unknown;
    }
}
