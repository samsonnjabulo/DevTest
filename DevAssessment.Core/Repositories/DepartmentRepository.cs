using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DevAssessment.Core.Interfaces;
using DevAssessment.DTO;
using DevAssessment.EntityFramework.Context;
using DevAssessment.Core.Mapper;

namespace DevAssessment.Core.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private DevAssessmentDBEntities _context;

        public DepartmentRepository(DevAssessmentDBEntities context) : base(context)
        {
            _context = context;
            DtoMapping.Map();
        }

        public List<DepartmentDTO> GetDepartments(Expression<Func<Department, bool>> predicate)
        {
            var results = Find(predicate);
            return AutoMapper.Mapper.Map<List<DepartmentDTO>>(results);
        }

        public DepartmentDTO GetDepartmentByID(int id)
        {
            var department = Get(id);
            return AutoMapper.Mapper.Map<DepartmentDTO>(department);
        }
        public int SaveDepartment(DepartmentDTO DepartmentDTO)
        {
            var department = AutoMapper.Mapper.Map<Department>(DepartmentDTO);
            return Add(department);

        }
    }
}