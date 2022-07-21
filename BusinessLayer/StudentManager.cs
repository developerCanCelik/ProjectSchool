using DataAccessLayer;
using EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentManager
    {
        Repository<Student> studentRepo = new Repository<Student>();
        
        public List<Student> GetAll()
        {
            return studentRepo.List();
        }
    
    }
}
