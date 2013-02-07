using System;
using Windows.UI.Interactivity;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace SubmodulesTest
{
    public class MessageAction : TriggerAction<FrameworkElement>
    {
        protected async override void Invoke(object parameter)
        {
            await new MessageDialog("triggered!").ShowAsync();
        }
    }
}
