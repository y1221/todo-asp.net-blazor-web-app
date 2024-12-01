using System.ComponentModel.DataAnnotations;

namespace TodoBlazorApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Display(Name = "タスク")]
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "30文字以内で入力してください。")]
        [Required(ErrorMessage = "必須項目です。")]
        public string Name { get; set; } = string.Empty;

        public bool IsDone { get; set; } = false;

        public bool IsDelete { get; set; } = false;
    }
}
