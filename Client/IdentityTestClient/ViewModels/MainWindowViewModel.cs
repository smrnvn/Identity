using IdentityTestClient.Models;
using IdentityTestClient.Repositories;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace IdentityTestClient.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _name;
        private string _password;
        private readonly IIdentityAPI _identityAPI;
        public MainWindowViewModel(IIdentityAPI identityAPI)
        {
            _identityAPI = identityAPI;
            LoginCommand = new DelegateCommand(Login);
            RegistrateCommand = new DelegateCommand(Registrate);
        }

        public DelegateCommand LoginCommand { get; set; }
        public DelegateCommand RegistrateCommand { get; set; }

        public string Name 
        { 
            get => _name; 
            set => SetProperty(ref _name, value); 
        }

        public string Password
        { 
            get => _password; 
            set => SetProperty(ref _password, value);
        }

        private async void Login()
        {
           var result = await _identityAPI.Login(new User() { Name = Name, Password = Password });
            if (result)
                MessageBox.Show("Вход!");
            else
                MessageBox.Show("Неверный пароль!");
        }

        private async void Registrate()
        {
            var result = await _identityAPI.Registrate(new User() { Name = Name, Password = Password });

            if (result.IsRegistrate)
                MessageBox.Show($"Пользователь зарегестрирован! id {result.User?.Id}");
            else
                MessageBox.Show("Пользователь не зарегестрирован!");
        }
    }
}
