using VisibleOnePOS.Models.Member;

namespace VisibleOnePOS.Views.Member;

public partial class MemberDetails : ContentPage
{
	public MemberDetails(MemberModel memberModel)
	{
		InitializeComponent();

        txtMemberName.Text = memberModel.MemberName;
        txtRedeemedPoints.Text = memberModel.RedeemedPoints.ToString();
        txtTotalPoints.Text = memberModel.TotalPoints.ToString();
    }
}