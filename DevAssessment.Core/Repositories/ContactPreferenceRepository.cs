using DevAssessment.Core.Interfaces;
using DevAssessment.EntityFramework.Context;

namespace DevAssessment.Core.Repositories
{
    public class ContactPreferenceRepository : Repository<ContactPreference>, IContactPreferenceRepository
    {
        private DevAssessmentDBEntities _context;

        public ContactPreferenceRepository(DevAssessmentDBEntities context): base(context)
        {
            _context = context;
        }
    }
}