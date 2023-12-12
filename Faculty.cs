using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Model
{
    public class Faculty
    {
        [Key]
        public int fid { get; set; }
        public string fname { get; set; }
        public int deptid { get; set; }
        public string standing { get; set;}
    }
}
