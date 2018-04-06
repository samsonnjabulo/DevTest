using DevAssessment.Core.Interfaces;
using DevAssessment.DTO;
using System;
using System.Collections.Generic;

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
                var results= _uow.DepartmentRepository.GetDepartmentByID(id);
                if (results == null || results.Name.Equals(String.Empty))
                {
                    return new DepartmentDTO() { Error = "Record not found" };
                }
                else
                    return results;
            }
            catch (Exception ex)
            {
                return new DepartmentDTO() { Error = "Something went wrong please try again later" };
            }
        }

        public List<DepartmentDTO> GetAllDepartment()
        {
            try
            {
                var results = _uow.DepartmentRepository.GetAllDepartments();
               return results;
            }
            catch (Exception ex)
            {
                return new List<DepartmentDTO>();
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
           
                    departmentDTO.Error = "Department saving failed";
              
                return new DepartmentDTO() { Error = "Something went wrong please try again later" };
            }
            catch (Exception)
            {
                return new DepartmentDTO() { Error = "Something went wrong please try again later" };
            }
        }


    }
}
