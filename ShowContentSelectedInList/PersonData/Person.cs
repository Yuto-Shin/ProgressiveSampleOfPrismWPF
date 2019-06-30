using System;
using Prism.Mvvm;

namespace PersonData {
    public class Person : BindableBase {
        string name;
        string sex;
        int age;

        public string Name { get => name; set => SetProperty(ref name,value); }

        public string Sex { get => sex; set => SetProperty(ref sex,value); }
        
        public int Age { get => age; set => SetProperty(ref age,value); }

        public Person(string _name,string _sex,int _age) {
            Name=_name;
            Sex = _sex;
            Age = _age;            
        }
    }
}
