using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using System.Diagnostics;
using VisibleOnePOS.ViewModels.Member;
using VisibleOnePOS.ViewModels.Transaction;

namespace VisibleOnePOS.Views.Transaction;

public partial class TransactionList : ContentPage
{
	TransactionViewModel TransactionViewModel { get; set; }
	public TransactionList()
    {
		InitializeComponent();
        BindingContext = TransactionViewModel = new TransactionViewModel();
    }
    bool loaded = false;

    [Obsolete]
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (loaded)
            return;
        loaded = true;
        try
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                Thickness safeInsets = On<iOS>().SafeAreaInsets();
                safeInsets.Bottom = 0;
                Padding = safeInsets;
                //UserDialogs.Instance.ShowLoading(AppResources.Loading_Res, MaskType.Black);

                await TransactionViewModel.ExcuteCommandTransactionList();
                //UserDialogs.Instance.HideLoading();
            });
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            //UserDialogs.Instance.HideLoading();
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
}