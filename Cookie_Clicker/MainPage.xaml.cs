global using Cookie_Clicker;
namespace Cookie_Clicker;

public partial class MainPage : ContentPage
{
    float count = 0f;
	public MainPage()
	{
        InitializeComponent();
        string txtNames = File.ReadAllText("C:/Users/Stepan/source/repos/Cookie_Clicker/Cookie_Clicker/txt/randomNames.txt");
        string txtNames2 = File.ReadAllText("C:/Users/Stepan/source/repos/Cookie_Clicker/Cookie_Clicker/txt/randomNames2.txt");
        string[] Names = txtNames.Split(";");
        string[] Names2 = txtNames2.Split(";");
        Random ramdon = new Random();
        int randomNames = ramdon.Next(0, 2);
        int randomIndex = ramdon.Next(0, 50);
        if (randomNames == 0)
            btnChangeName.Text = $"{Names[randomIndex]}'s bakery";
        else
            btnChangeName.Text = $"{Names2[randomIndex]}'s bakery";
    }

	private void btnC_Clicked(object sender, EventArgs e)
	{
		count++;
		if (count == 1)
			totalCs.Text = $"{count} cookie";
		else
			totalCs.Text = $"{count} cookies";

		SemanticScreenReader.Announce(perSecCs.Text);
	}
    private async void btnStats_Clicked(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Stats", "Back", null, $"Cookies in bank: {totalCs.Text}",$"Total clicked cookies: {count.ToString()} cookies", $"Total clicks: {Convert.ToString(count)}", "Runtime: ");

    }

    private void btnInfo_Clicked(object sender, EventArgs e)
    {
		string info = "";
    }
    private async void btnChangeName_Clicked(object sender, EventArgs e)
    {

        string change = await DisplayPromptAsync("Change name of your bakery", "Your name: ");
            btnChangeName.Text = $"{change}'s bakery";
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {

    }

    private void btnLoad_Clicked(object sender, EventArgs e)
    {

    }
}

//https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/essential-syntax?view=net-maui-7.0
