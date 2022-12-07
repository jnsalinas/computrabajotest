using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ComputrabajoTest.App.ViewModels.Base;
using ComputrabajoTest.Entities;
using ComputrabajoTest.Entities.Base;
using ComputrabajoTest.Proxy.Bases;

namespace ComputrabajoTest.App.ViewModels
{
    public class UserVM : ViewModelBase
    {
        #region commands
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Command GetUsersCommand { get; set; }
        public Command GetUserDetailCommand { get; set; }
        #endregion commands

        #region properties
        /// <summary>
        /// number of rows to return service
        /// </summary>
        private const int rowsToRequestService = 50;

        /// <summary>
        /// number default page
        /// </summary>
        private int page { get; set; } = 0;

        /// <summary>
        /// list users for listview
        /// </summary>
        private ObservableCollection<User> _users;
        public ObservableCollection<User> users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChange();
            }
        }

        /// <summary>
        /// user selected for show detail
        /// </summary>
        private User _selectedUser;
        public User selectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChange();
            }
        }
        #endregion properties

        #region ctor
        public UserVM()
        {
            GetUsersCommand = new Command(async () => await _GetUsers());
            GetUserDetailCommand = new Command(async () => await _GetUserDetail());
        }
        #endregion

        #region commands
        /// <summary>
        /// Consulta los usuarios en el servicio con un numero de pagina y numero de registros.
        /// Para este caso no se realizo paginación para el listview, solo consulta la pagina inicializada
        /// </summary>
        /// <returns></returns>
        private async Task _GetUsers()
        {
            try
            {
                BasicCrud<BaseGetAllOut<User>> basicCrud = new BasicCrud<BaseGetAllOut<User>>();
                BaseGetAllOut<User> BaseGetAllOutUser = await basicCrud.Get("redarbor", new Dictionary<string, string>()
                {
                    { "page", page.ToString()  },
                    { "toShow", rowsToRequestService.ToString() },
                });

                users = BaseGetAllOutUser.listResult;
                OnPropertyChange(nameof(users));
                OnPropertyChange(nameof(_users));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception - save log or define action {ex.Message}");
            }
        }

        /// <summary>
        /// Consulta el detalle de un usuario, este consulta todos los objetos relacionados a el (Rol,Company,Status,Portal)
        /// </summary>
        /// <returns></returns>
        private async Task _GetUserDetail()
        {
            try
            {
                BasicCrud<BaseGetDetailOut<User>> basicCrud = new BasicCrud<BaseGetDetailOut<User>>();
                BaseGetDetailOut<User> BaseGetAllOutUser = await basicCrud.Get("redarbordetail", new Dictionary<string, string>()
                {
                    { "id", selectedUser.id  },
                });

                selectedUser = BaseGetAllOutUser.resultEntity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception - save log or define action {ex.Message}");
            }
        }
        #endregion
    }
}

