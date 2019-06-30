using Prism.Mvvm;
using Prism.Regions;
using ShowContentSelectedInList.Views;

namespace ShowContentSelectedInList.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        /// <summary>
        /// MainWindowのコンストラクタでListRegion内にListControlを挿入しておく。
        /// これによってMainWindowを開いた時点でListControlが表示されるようになる。
        /// </summary>
        /// <param name="regionManager"></param>
        public MainWindowViewModel(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion("ListRegion",typeof(ListControl));
        }
    }
}
