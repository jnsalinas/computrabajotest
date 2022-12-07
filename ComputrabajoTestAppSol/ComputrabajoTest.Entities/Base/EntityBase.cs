using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ComputrabajoTest.Entities.Base
{
	public class EntityBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string propertyName = "")
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; OnPropertyChange(); }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; OnPropertyChange(); }
        }
    }
}

