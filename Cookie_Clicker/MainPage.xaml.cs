namespace Cookie_Clicker;

public partial class MainPage : ContentPage
{
	float count = 0f;

	public MainPage()
	{
		InitializeComponent();

	}

	private void btnC_Clicked(object sender, EventArgs e)
	{
		count++;
		if (count == 1)
			totalCs.Text = $"{count} cookie";
		else
			totalCs.Text = $"{count} cookies";
		
		//if (count == 1)
		//	perSecCs.Text = $"{count / 100} cookie per second";
		//else
		//	perSecCs.Text = $"{count / 100} cookies per second";

		SemanticScreenReader.Announce(perSecCs.Text);
		//SemanticScreenReader.Announce(btnC.Text);
	}
    private void btnStats_Clicked(object sender, EventArgs e)
    {

    }

    private void btnInfo_Clicked(object sender, EventArgs e)
    {

    }
}

