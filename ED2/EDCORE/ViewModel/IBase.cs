using System.ComponentModel;

namespace EDCORE.ViewModel
{
    public interface IBase
    {
        string Title { get; set; }
        string Subtitle { get; set; }
        string Icon { get; set; }
        bool IsBusy { get; set; }
        bool IsNotBusy { get; set; }
        bool CanLoadMore { get; set; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}