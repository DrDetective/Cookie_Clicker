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
    private async void btnStats_Clicked(object sender, EventArgs e)
    {
        //DisplayAlert($"Total cookies: {totalCs}", "OK");
        string action = await DisplayActionSheet("Stats", "Back", null, $"Total cookies: {totalCs.Text}",$"Total clicked cookies: {count.ToString()} cookies", $"Total clicks: {Convert.ToString(count)}", "Runtime: ");

    }

    private void btnInfo_Clicked(object sender, EventArgs e)
    {
		string info = "";
    }
    private async void btnChangeName_Clicked(object sender, EventArgs e)
    {
		string change = await DisplayPromptAsync("Change name of your bakery","Your name: ");
		nameOfBakery.Text =$"{change}'s bakery";
    }
}

//https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/essential-syntax?view=net-maui-7.0
