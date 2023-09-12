using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ninjaflex.Application.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "É necessário informar o id do usuário.")]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário informar a data de criação do usuário.")]
        [DisplayName("DateCreation")]
        public DateTime DateCreation { get; set; }

        [Required(ErrorMessage = "É necessário informar a data de alteração do usuário.")]
        [DisplayName("DateCreation")]
        public DateTime DateAlteration { get; set; }

        [Required(ErrorMessage = "É necessário informar o primeiro nome do usuário.")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "É necessário informar o segundo nome do usuário.")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "É necessário informar o e-mail do usuário.")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário informar a senha do usuário.")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [MaxLength(10)]
        [DisplayName("BarCode")]
        public string? BarCode { get; set; }

        [Required(ErrorMessage = "É necessário informar o tipo do usuário.")]
        [DisplayName("UserTypeId")]
        public int UserTypeId { get; set; }

        [Required(ErrorMessage = "É necessário informar o status do usuário.")]
        [DisplayName("Status")]
        public bool Status { get; set; }
    }
}
