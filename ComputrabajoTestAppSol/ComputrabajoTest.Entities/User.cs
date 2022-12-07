using System;
using System.ComponentModel.DataAnnotations;
using ComputrabajoTest.Entities.Base;

namespace ComputrabajoTest.Entities
{
	public class User : EntityBase
    {
        private string _username;
        public string username
        {
            get { return _username; }
            set { _username = value; OnPropertyChange(); }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; OnPropertyChange(); }
        }

        private DateTime _createdOn;
        public DateTime createdOn
        {
            get { return _createdOn; }
            set { _createdOn = value; OnPropertyChange(); }
        }

        private DateTime? _deletedOn;
        public DateTime? deletedOn
        {
            get { return _deletedOn; }
            set { _deletedOn = value; OnPropertyChange(); }
        }

        private string _fax;
        public string fax
        {
            get { return _fax; }
            set { _fax = value; OnPropertyChange(); }
        }

        private DateTime? _lastLogin;
        public DateTime? lastLogin
        {
            get { return _lastLogin; }
            set { _lastLogin = value; OnPropertyChange(); }
        }


        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; OnPropertyChange(); }
        }

        private string _telephone;
        public string telephone
        {
            get { return _telephone; }
            set { _telephone = value; OnPropertyChange(); }
        }

        private DateTime? _updatedOn;
        public DateTime? updatedOn
        {
            get { return _updatedOn; }
            set { _updatedOn = value; OnPropertyChange(); }
        }


        private Company _company;
        public Company company
        {
            get { return _company; }
            set { _company = value; OnPropertyChange(); }
        }

        private Role _role;
        public Role role
        {
            get { return _role; }
            set { _role = value; OnPropertyChange(); }
        }

        private Portal _portal;
        public Portal portal
        {
            get { return _portal; }
            set { _portal = value; OnPropertyChange(); }
        }

        private Status _status;
        public Status status
        {
            get { return _status; }
            set { _status = value; OnPropertyChange(); }
        }
    }
}

