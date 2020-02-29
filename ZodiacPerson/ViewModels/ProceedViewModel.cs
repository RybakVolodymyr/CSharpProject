using ZodiacPerson.Managers;
using ZodiacPerson.Models;
using ZodiacPerson.Tools;

namespace ZodiacPerson.ViewModels
{
    internal class ProceedViewModel
    {
        #region Fields

        private readonly Person _person;

        #region Commands

        private RelayCommand<object> _backCommand;

        #endregion

        #endregion

        #region Properties

        public string FirstName => $"Your name: {_person.FirstName}";
        public string LastName => $"Your surname: {_person.LastName}";
        public string Email => $"Your email: {_person.Email}";
        public string BirthDate => $"Your birthday: {_person.BirthDate.ToShortDateString()}";
        public string SunSign => $"Your sun sign: {_person.SunSign}";
        public string ChineseSign => $"Your chinese sign: {_person.ChineseSign}";
        public string IsBirthday => $"Today is {(_person.IsBirthday ? "" : "not ")}your birthday";
        public string IsAdult => $"You are {(_person.IsAdult ? "" : "not ")}adult";

        public RelayCommand<object> BackCommand =>
            _backCommand ?? (_backCommand = new RelayCommand<object>(BackExecute));

        #endregion

        public ProceedViewModel()
        {
            _person = StationManager.CurrentPerson;
        }

        private void BackExecute(object obj)
        {
            NavigationManager.Instance.Navigate(ModesEnum.DataPerson);
        }
    }
}