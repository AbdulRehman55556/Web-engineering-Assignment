using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Model
{
    public class Class
    {
        [Key]
        public int cid { get; set; }
        public string name { get; set; }
        public int room_number { get; set; }




        public int Facultyfid { get; set;}
        public Faculty Faculty { get; set; }    
       
    }
}
