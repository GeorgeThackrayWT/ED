using System;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IStoreManager
    {
        bool IsInitialized { get; }
        
        ITaskStore TaskStore { get; }    
     
        Task<bool> SyncAllAsync(bool syncUserSpecific);
        Task DropEverythingAsync();
        Task InitializeAsync();
    }
}

