using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPT.Model;

namespace XamarinPT.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowData : ContentPage
    {
        private List<Kanji> kanjiList = new List<Kanji>();
        public ShowData()
        {
            InitializeComponent();
            this.BindingContext = this;
            ShowTableData();
            kanjiView.ItemsSource = kanjiList;
        }

        private void ShowTableData()
        {
            kanjiList = SqliteManager.GetAllTable<Kanji>();
        }
    }
}