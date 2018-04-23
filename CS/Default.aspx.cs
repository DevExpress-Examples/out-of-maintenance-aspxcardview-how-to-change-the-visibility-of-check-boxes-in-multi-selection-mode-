using System;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ASPxCardView1_CommandButtonInitialize(object sender, DevExpress.Web.ASPxCardViewCommandButtonEventArgs e)
    {
        if (e.ButtonType == CardViewCommandButtonType.SelectCheckbox)
            e.Visible = !chkDisabled.Checked;
    }
}