using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BOL
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Пароль")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Фамилия")]
        public string SecondName { get; set; }

        [HiddenInput]
        public int GroupId { get; set; }

        [DisplayName("Группа")]
        public virtual Group Group { get; set; }
    }
}
