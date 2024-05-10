using System.ComponentModel.DataAnnotations;

namespace TrainBooking.Model
{
    public class Train
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "Not given";
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; } 
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        [Required]
        public int TrainBox {  get; set; }
       
       


    }
}
