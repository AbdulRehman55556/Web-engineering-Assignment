using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Model
{
    public class Enrolled
    {
        [Key]
        public int Id { get; set; }
        public int Facultyfid { get; set; }
        public Faculty Faculty { get; set; }

        public int Studentsid { get; set; }
        public Student Student { get; set; }
  
   
    }
}
