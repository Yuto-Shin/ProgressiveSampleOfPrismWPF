using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using PersonData;
using Prism.Regions;

namespace ShowContentSelectedInList.ViewModels {
    public class ContentControlViewModel : BindableBase,INavigationAware {
        Person person;
        public Person Person { get => person; set => SetProperty(ref person,value); }

        /// <summary>
        /// ナビゲーションの対象とできるかという判定を行う。
        /// 今回はいつでもナビゲーション可能なので判定無しで常にTrueを返すようにする。
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <returns></returns>
        public bool IsNavigationTarget(NavigationContext navigationContext) =>true;
        public void OnNavigatedFrom(NavigationContext navigationContext) { }

        /// <summary>
        /// 他のユーザコントロールからナビゲーションされてきた場合に実行されるメソッド。
        /// ここでは、このViewModelの持つPersonプロパティにListControlから渡されてきたPersonプロパティをセットする。
        /// </summary>
        /// <param name="navigationContext">ListControlから送られてきたパラメータ。（ListControlのchangeContentメソッド内にあるRequestNavigateの第三引数）</param>
        public void OnNavigatedTo(NavigationContext navigationContext) => Person = navigationContext.Parameters["ShowContent"] as Person;
    }
}