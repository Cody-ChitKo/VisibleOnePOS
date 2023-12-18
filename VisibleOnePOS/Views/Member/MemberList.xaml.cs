using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using System.Diagnostics;
using VisibleOnePOS.Models.Member;
using VisibleOnePOS.ViewModels.Member;

namespace VisibleOnePOS.Views.Member;

public partial class MemberList : ContentPage
{
    MemberViewModel memberViewModel { get; set; }
    public MemberList()
    {
        InitializeComponent();
        BindingContext = memberViewModel = new MemberViewModel();

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

                await memberViewModel.ExcuteCommandMemberList();
                //UserDialogs.Instance.HideLoading();
            });
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            //UserDialogs.Instance.HideLoading();
        }
    }

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        memberViewModel.SelectedMember = e.CurrentSelection[0] as MemberModel;

        if (memberViewModel.SelectedMember != null)
        {
            Navigation.PushAsync(new MemberDetails(memberViewModel.SelectedMember));
        }
        else
        {
            Debug.WriteLine("SelectedServices is null");
        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
       // await Navigation.PushAsync(new MemberDetails(memberViewModel.SelectedMember));
    }
}