using DevAssessment.Core.Interfaces;
using DevAssessment.EntityFramework.Context;

namespace DevAssessment.Core.Repositories
{
    public class GenderRepository : Repository<Gender>,  IGenderRepository
    {
        private DevAssessmentDBEntities _context;

        public GenderRepository(DevAssessmentDBEntities context) : base(context)
        {
            _context = context;
        }
    }
}