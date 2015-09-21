using CefSharp.MinimalExample.Wpf.Mvvm;
using CefSharp.Wpf;
using System.ComponentModel;
using System.Windows;

namespace CefSharp.MinimalExample.Wpf.ViewModels
{
    public class MainViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IWpfWebBrowser webBrowser;
        public IWpfWebBrowser WebBrowser
        {
            get { return webBrowser; }
            set { PropertyChanged.ChangeAndNotify(ref webBrowser, value, () => WebBrowser); }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { PropertyChanged.ChangeAndNotify(ref title, value, () => Title); }
        }

        private string addressBing;
        public string AddressBing
        {
            get { return addressBing; }
            set { PropertyChanged.ChangeAndNotify(ref addressBing, value, () => AddressBing); }
        }

        private string addressGoogle;
        public string AddressGoogle
        {
            get { return addressGoogle; }
            set { PropertyChanged.ChangeAndNotify(ref addressGoogle, value, () => AddressGoogle); }
        }

        private string addressLocal;
        public string AddressLocal
        {
            get { return addressLocal; }
            set { PropertyChanged.ChangeAndNotify(ref addressLocal, value, () => AddressLocal); }
        }

        public MainViewModel()
        {
            PropertyChanged += OnPropertyChanged;
            AddressBing = "https://www.bing.com";
            AddressGoogle = "http://www.google.com";
            AddressLocal = "file:///C:/test/index.html";
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Title")
            {
                Application.Current.MainWindow.Title = "CefSharp.MinimalExample.Wpf - " + Title;
            }
        }
    }
}
