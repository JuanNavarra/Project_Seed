namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IUnitOfWork : IDisposable
    {
        public GenericContext Context { get; }
        public void Commit();
    }
}
