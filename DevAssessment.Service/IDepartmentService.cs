using DevAssessment.DTO;

namespace DevAssessment.Service
{
    public interface IDepartmentService
    {
        DepartmentDTO SaveDepartment(DepartmentDTO departmentDTO);
        DepartmentDTO GetDepartmentByID(int id);
    }
}