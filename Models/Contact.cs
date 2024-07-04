using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [StringLength(50, MinimumLength =2, ErrorMessage ="Имя не менее 2 символов")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Surname { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public int Age {  get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Message { get; set; }


        // проверка совпадения при повторном наборе пароля

        //[Required]
        //public string? Password { get; set; }

        //[Compare("Password", ErrorMessage = "Пароли не совпадают")]
        //public string? PasswordConfirm { get; set; }
    }
}
