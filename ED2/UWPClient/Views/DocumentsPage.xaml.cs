﻿using Windows.UI.Xaml.Controls;
using EDCORE.ViewModel;
using FreshMvvm;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WT.UWP.ED2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DocumentsPage : Page
    {

        internal IDocumentsModel ViewModel;
    
        public DocumentsPage()
        {
            this.InitializeComponent();
                      
            ViewModel = FreshIOC.Container.Resolve<IDocumentsModel>();

            this.DataContext = ViewModel.DocumentsList;
        }

        
    }
}
