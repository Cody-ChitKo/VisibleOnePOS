using Microcharts;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using SkiaSharp;
using System.Collections.ObjectModel;
using System.Diagnostics;
using VisibleOnePOS.Models.Branch;
using VisibleOnePOS.ViewModels.Branch;

namespace VisibleOnePOS.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
    BranchViewModel BranchViewModel { get; set; }
    public DashboardPage()
	{
		InitializeComponent();
        BindingContext = BranchViewModel = new BranchViewModel();
        chartView.Chart = new BarChart
        {
            Entries = entries
        };
    }
    ChartEntry[] entries = new[]
        {
            new ChartEntry(212)
            {
                Label="Corn",
                ValueLabel="122",
                Color=SKColor.Parse("#2c3e50")
            },
            new ChartEntry(248)
            {
                Label="HP",
                ValueLabel="648",
                Color=SKColor.Parse("#77d065")
            },
            new ChartEntry(212)
            {
                Label="Dell",
                ValueLabel="428",
                Color=SKColor.Parse("#b455b6")
            },
            new ChartEntry(514)
            {
                Label="Acer",
                ValueLabel="214",
                Color=SKColor.Parse("#3498db")
            }
        };

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

                await BranchViewModel.ExcuetBranchListCommand();
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