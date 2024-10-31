using System.ComponentModel.DataAnnotations;

namespace CititesManager.WebAPI.Models
{
    public class City
    {
        [Key]
        public Guid CityId { get; set; }
        [Required(ErrorMessage ="City Name can't be blank")]
        public string CityName { get; set; } = null!;
    }
}
