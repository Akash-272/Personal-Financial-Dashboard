using System.ComponentModel.DataAnnotations;

namespace Personal_Financial_Dashboard.Model.Dto
{
    public class RegisterRequestDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }


        [Required]
        [DataType (DataType.Password)]
        public string Password { get; set; }

    }
}
