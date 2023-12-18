using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using System.Diagnostics;
using VisibleOnePOS.ViewModels.Branch;

namespace VisibleOnePOS.Views.Branch;

public partial class BranchList : ContentPage
{
    BranchViewModel _branchViewModel { get; set; }
    public BranchList()
    {
        InitializeComponent();
        BindingContext = _branchViewModel = new BranchViewModel();
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

                await _branchViewModel.ExcuetBranchListCommand();
                //UserDialogs.Instance.HideLoading();
            });
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            //UserDialogs.Instance.HideLoading();
        }
    }
}