using DevAssessment.DTO;
using System.Collections.Generic;

namespace DevAssessment.Service
{
    public interface IDepartmentService
    {
        DepartmentDTO SaveDepartment(DepartmentDTO departmentDTO);
        DepartmentDTO GetDepartmentByID(int id);
        List<DepartmentDTO> GetAllDepartment();
    }
}