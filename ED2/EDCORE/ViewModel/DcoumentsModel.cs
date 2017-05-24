using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;
using SQLite;

namespace EDCORE.ViewModel
{

    public interface IDocumentsModel : INotifyPropertyChanged
    {
        ObservableCollection<Document> DocumentsList { get; }
    }

    public class DocumentsModel : ViewModelBase, IDocumentsModel
    {     
        private readonly ITestDataDal _testDataDal;

        public DocumentsModel(ITestDataDal iTestDataDal)
        {
            _testDataDal = iTestDataDal;
        }

        public ObservableCollection<Document> DocumentsList => _testDataDal.Documents;
    }
}