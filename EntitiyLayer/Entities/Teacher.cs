using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Entities
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        [StringLength(50)]
        public string? TeacherName { get; set; }
        [StringLength(50)]
        public string? TeacherBranch { get; set; }

        public ICollection<Student> Students { get; set; }


    }
}
