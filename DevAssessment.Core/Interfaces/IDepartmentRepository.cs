using DevAssessment.DTO;
using DevAssessment.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevAssessment.Core.Interfaces
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        int SaveDepartment(DepartmentDTO DepartmentDTO);
        List<DepartmentDTO> GetDepartments(Expression<Func<Department, bool>> predicate);
        DepartmentDTO GetDepartmentByID(int id);
        List<DepartmentDTO> GetAllDepartments();

    }
}
