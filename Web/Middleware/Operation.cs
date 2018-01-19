using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Web.Middleware.DependencyInjectionSample;

namespace Web.Middleware
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        private Guid _guid;
        public Guid OperationId => _guid; 
        public Operation(Guid guid)
        {
            _guid = guid;
        }
        

        public Operation()
        {
            _guid = Guid.NewGuid();
        }
}

    
}
