using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using PersonData;

namespace PersonData {
    public class PersonList {
        public ObservableCollection<Person> People { get; set; }

        public PersonList() {
            People = new ObservableCollection<Person>();
            People.Add(new Person("太郎","男",19));
            People.Add(new Person("次郎","男",18));
            People.Add(new Person("花子","女",16));
        }
    }
}
