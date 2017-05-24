using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;
using SQLite;

namespace EDCORE.ViewModel
{

    public interface IInternalAuditModel : INotifyPropertyChanged
    {
        ObservableCollection<InternalAudit> InternalAudits { get; }
    }


    public class InternalAuditModel : ViewModelBase, IInternalAuditModel
    {
        private readonly ITestDataDal _idal;

        public InternalAuditModel(ITestDataDal iTestDataDal)
        {
            _idal = iTestDataDal;
        }

        public ObservableCollection<InternalAudit> InternalAudits => _idal.InternalAudits;
    }
}