using DevAssessment.Core.Interfaces;
using DevAssessment.EntityFramework.Context;

namespace DevAssessment.Core.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private DevAssessmentDBEntities _context;

        public StudentRepository(DevAssessmentDBEntities context) : base(context)
        {
            _context = context;
        }
    }
}