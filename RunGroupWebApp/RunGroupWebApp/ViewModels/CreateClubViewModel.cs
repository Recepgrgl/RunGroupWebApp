using RunGroupWebApp.Data.Enum;
using RunGroupWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.ViewModels
{
    public class CreateClubViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunlu"), MinLength(10)]
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
    public ClubCategory ClubCategory { get; set; }
    }
}
