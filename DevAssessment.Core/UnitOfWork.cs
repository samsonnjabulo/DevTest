using DevAssessment.Core.Repositories;
using DevAssessment.EntityFramework.Context;
using System;
using System.Data.Entity.Validation;

namespace DevAssessment.Core.Interfaces
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DevAssessmentDBEntities _context;
        private IGenderRepository _genderRepository;
        private IStudentRepository _studentRepository;
        private IDepartmentRepository _departmentRepository;
        private IContactPreferenceRepository _contactPreferenceRepository;
       

        public UnitOfWork()
        {
            if (_context == null)
                _context = new DevAssessmentDBEntities();
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                return _studentRepository ?? (_studentRepository = new StudentRepository(_context));
            }
        }
        public IGenderRepository GenderRepository
        {
            get
            {
                return _genderRepository ?? (_genderRepository = new GenderRepository(_context));
            }
        }

      
        public IContactPreferenceRepository ContactPreferenceRepository
        {
            get
            {
                return _contactPreferenceRepository ?? (_contactPreferenceRepository = new ContactPreferenceRepository(_context));
            }
        }

       
        public IDepartmentRepository DepartmentRepository
        {
            get
            {
                return _departmentRepository ?? (_departmentRepository = new DepartmentRepository(_context));
            }
        }

      
     
    

        public int Complete()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        var c = validationErrors.Entry.Entity.GetType().FullName;
                        var a = validationError.PropertyName;
                        var b = validationError.ErrorMessage;
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
