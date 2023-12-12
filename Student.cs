using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Model
{
    public class Student
    {
        [Key]
        public int sid { get; set; }
        public string sname { get; set; }
        public string major { get; set; }
        public string standing { get; set; }
    }
}
