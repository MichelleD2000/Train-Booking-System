using System.ComponentModel.DataAnnotations;

namespace TrainBooking.DTO
{
    public class TrainReadDTO
    {
        public int Id { get; set; }
    
        public string Name { get; set; } = "Not given";
        
        public string Date { get; set; }
        
        public string Time { get; set; }
        
        public string Start { get; set; }
        public string End { get; set; }
     
        public int TrainBox { get; set; }
       
    }
}
