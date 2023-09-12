using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjaflex.Application.ViewModels
{
    public class UserTypeViewModel
    {
        [Required(ErrorMessage = "A id do tipo de usuário é obrigatório.")]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "A data de criação do tipo de usuário é obrigatório.")]
        [DisplayName("DateCreation")]
        public DateTime DateCreation { get; set; }

        [Required(ErrorMessage = "A data de alteração do tipo de usuário é obrigatório.")]
        [DisplayName("DateAlteration")]
        public DateTime DateAlteration { get; set; }

        [Required(ErrorMessage = "A descrição do tipo de usuário é obrigatório.")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "É necessário informar o status do tipo de usuário.")]
        [DisplayName("Status")]
        public bool Status { get; set; }
    }
}
