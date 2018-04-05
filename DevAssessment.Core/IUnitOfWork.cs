using System;

namespace DevAssessment.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
