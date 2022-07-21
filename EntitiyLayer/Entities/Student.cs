using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [StringLength(50)]
        public string? StudentName { get; set; }
        [StringLength(50)]
        public string? StudentClass { get; set; }

        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
