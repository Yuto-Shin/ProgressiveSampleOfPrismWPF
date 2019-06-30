using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PersonData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowContentSelectedInList.ViewModels {
    public class ListControlViewModel : BindableBase {
        /// <summary>
        /// IRegionManagerは他のビューに遷移させる際に必要。
        /// 今回はリストで選んだ内容のContentControlに遷移させる際に使う。
        /// </summary>
        IRegionManager regionManager;

        public PersonList PersonList { get; }
        /// <summary>
        /// DelegateCommandは「宣言をする」「実行するメソッドを書く」「コンストラクタ内でメソッドと紐付いた実体を格納する」ことで使えるようになる。
        /// </summary>
        public DelegateCommand<object> ChangeContent { get; private set; }

        /// <summary>
        /// コンストラクタ内ではDIに格納された物を持ってくることができる。
        /// このViewModelで必要なIRegionManagerとPersonListを持ってきて、事前に宣言しておいたメンバー変数に格納する。
        /// なお、他にも必要な物があればコンストラクタの引数に追加すればDIに存在する物ならDIが自動的に挿入してくれる。
        /// </summary>
        /// <param name="region"></param>
        /// <param name="list"></param>
        public ListControlViewModel(IRegionManager region,PersonList list) {
            regionManager = region;
            PersonList = list;
            ChangeContent = new DelegateCommand<object>(changeContent);
        }

        /// <summary>
        /// ContentControlのナビゲーションを実際に行うメソッド。
        /// Viewから送られてきたPersonをNavigationParameters内に格納し、ContentControlをContentRegion内に挿入する。
        /// このNavigationParametersはContentControl内で開封する。
        /// </summary>
        /// <param name="content">Viewから送られてきたCommandParameter。中身はobjectにキャストされたPerson。</param>
        void changeContent(object content) {
            var item = new NavigationParameters();
            item.Add("ShowContent",content);
            regionManager.RequestNavigate("ContentRegion","ContentControl",item);
        }

    }
}
