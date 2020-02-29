using System;
using ZodiacPerson.Views;

namespace ZodiacPerson.Tools
{
    internal enum ModesEnum
    {
        DataPerson,
        Proceeded
    }

    internal class NavigationModel
    {
        private readonly IContentWindow _contentWindow;

        internal NavigationModel(IContentWindow contentWindow)
        {
            _contentWindow = contentWindow;
        }

        internal void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.DataPerson:
                    _contentWindow.ContentControl.Content = new DataPersonView();
                    break;
                case ModesEnum.Proceeded:
                    _contentWindow.ContentControl.Content = new ProceededView();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}