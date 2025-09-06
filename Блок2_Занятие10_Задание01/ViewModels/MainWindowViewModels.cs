using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Input;
using Блок2_Занятие10_Задание01.Command;
using Блок2_Занятие10_Задание01.Models;

namespace Блок2_Занятие10_Задание01.ViewModels
{
    internal class MainWindowViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName_User)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName_User));
        }

        private string? _userNameLogin;
        private string? _userPassword;
        private string? _statusMessage = "Введите данные";
        private bool _isSuccess;

        public string? UserName
        {
            get => _userNameLogin;
            set { _userNameLogin = value; OnPropertyChanged(nameof(UserName)); }
        }
        public string? Password
        {
            get => _userPassword; set { _userPassword = value; OnPropertyChanged(nameof(Password)); }
        }
        public string? StatusMessage
        {
            get => _statusMessage; set { _statusMessage = value; OnPropertyChanged(nameof(StatusMessage)); }
        }
        public bool IsSuccess
        {
            get => _isSuccess;
            set
            {
                _isSuccess = value; OnPropertyChanged(nameof(IsSuccess));
            }
        }
        public ICommand AddddCommand { get; }
        private bool CanAddddCommandExecute(object? parameter) => UserName != null && Password != null;
        private void OnAddddCommandExecute(object? parameter)
        {
            if (AuthModel.Authenticate(UserName, Password) == true) { StatusMessage = "ДА"; IsSuccess = true; }
            else { StatusMessage = "ДА,но нет"; IsSuccess = false; }
        }
        public MainWindowViewModels() { AddddCommand = new RelayCommand(OnAddddCommandExecute, CanAddddCommandExecute); }
    }
}