using System.Collections.Generic;
using System.Threading.Tasks;
using DataObjects;
using Task = System.Threading.Tasks.Task;

namespace Abstractions
{
    public interface IBaseStore
    {     
        Task<string> TableExists(string tableName);

    }


}