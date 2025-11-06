using System.ComponentModel.DataAnnotations;

namespace BlazorTrainingNov250586.Components.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(10, MinimumLength =3, ErrorMessage ="Bitte zwischen 3 und 10 Zeichen")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Da muss was rein")]
        public DateTime GebDat { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(150,250, ErrorMessage ="Bitte zwischen 150 und 250")]
        public  int Gross { get; set; }
    }
}
