using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using İntro.Entities;

namespace İntro.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();

    void Add(Course course);
}
