using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace crud.Models
{
    public class Subscription
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage =("Informe o Titulo!"))]
        [StringLength(80, ErrorMessage =("O titulo deve conter no máximo 80 caracteres!"))]
        [MinLength(5, ErrorMessage = ("O titulo deve conter no mínimo 5 caracteres!"))]
        [DisplayName("Titulo")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [DisplayName("Inicio")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Término")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage =("Informe o Aluno!"))]
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}