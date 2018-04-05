using DevAssessment.Core.Interfaces;
using DevAssessment.DTO;
using System;

namespace DevAssessment.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly UnitOfWork _uow = new UnitOfWork();

        public DepartmentService() { }

        public DepartmentDTO GetDepartmentByID(int id)
        {
            try
            {
                return _uow.DepartmentRepository.GetDepartmentByID(id);
            }
            catch (Exception)
            {
                return new DepartmentDTO() { Error = "Something went wrong please try again later" };
            }
        }

        public DepartmentDTO SaveDepartment(DepartmentDTO departmentDTO)
        {
            try
            {
                int result = _uow.DepartmentRepository.SaveDepartment(departmentDTO);
                if (result > 0)
                {
                    departmentDTO.Error = "Department saved";
                }
                else
                {
                    departmentDTO.Error = "Department saving failed";
                }
                return new DepartmentDTO() { Error = "Something went wrong please try again later" };
            }
            catch (Exception)
            {
                return new DepartmentDTO() { Error = "Something went wrong please try again later" };
            }
        }


    }
}
