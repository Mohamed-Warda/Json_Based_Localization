using System.ComponentModel.DataAnnotations;

namespace JsonBasedLocalization.Web.Dtos;

public class CreateTestDto
{
        [Display(Name = "name"), Required(ErrorMessage = "required")]
        public string Name { get; set; }
}