using Microsoft.Extensions.Primitives;

namespace SmartClinicAPI.Models
{
    public class User//class for user model
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Role { get; set; } = String.Empty;
    }
}