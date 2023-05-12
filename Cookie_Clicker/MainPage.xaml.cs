global using Cookie_Clicker;
using System.IO;

namespace Cookie_Clicker;

public partial class MainPage : ContentPage
{
    float count = 0f;
    string[] nacteneFormy = Array.Empty<string>();
    string[] nacteneTypy = Array.Empty<string>();

    private async void NactiData(bool prvni)
    {
        Random ramdon = new Random();
        int randomNames = ramdon.Next(0, 2);
        Stream txtNames;
        if (prvni)
        {
            txtNames = await FileSystem.OpenAppPackageFileAsync("randomNames.txt");
        }
        else
        {
            txtNames = await FileSystem.OpenAppPackageFileAsync("randomNames2.txt");
        }
        StreamReader reader = new StreamReader(txtNames);
        string text = reader.ReadToEnd();
        string[] rozdeleny = text.Split(";");
        if (prvni)
        {
            nacteneFormy = rozdeleny;
        }
        else
        {
            nacteneTypy = rozdeleny;
        }
        int randomIndex = ramdon.Next(0, nacteneFormy.Length);
        NactiData(false);
        if (randomNames == 0)
            btnChangeName.Text = $"{nacteneFormy[randomIndex]}'s bakery";
        else
            btnChangeName.Text = $"{nacteneTypy[randomIndex]}'s bakery";
    }
    public MainPage()
	{
        InitializeComponent();
        if (swchModes.IsToggled) //DEFAULT IS WHITE MODE    
        {

        }
        else //DARK MODE
        {

        }
    }

    private void btnC_Clicked(object sender, EventArgs e) //COOKIE BUTTON
	{
        count++;
		if (count == 1)
			totalCs.Text = $"{count} cookie";
		else
			totalCs.Text = $"{count} cookies";
		SemanticScreenReader.Announce(perSecCs.Text);
	}
    private async void btnStats_Clicked(object sender, EventArgs e) //STATS OF GAME
    {
        string statsString = await DisplayActionSheet("Stats", "Back", null, $"Cookies in bank: {totalCs.Text}",$"Total clicked cookies: {count.ToString()} cookies", $"Total clicks: {Convert.ToString(count)}", "Runtime: ");
    }

    private void btnInfo_Clicked(object sender, EventArgs e) //INFO ABOUT THE GAME
    {
		string info = "";
    }
    private async void btnChangeName_Clicked(object sender, EventArgs e) //BUTTON TO CHANGE YOUR NAME OF BAKERY
    {

        string change = await DisplayPromptAsync("Change name of your bakery", "Your name: ");
            btnChangeName.Text = $"{change}'s bakery";
    }

    private void btnSave_Clicked(object sender, EventArgs e) //SAVE BUTTON, 2 METHODS TO SAVE, CLOUD (REQUIRES TO CHANGE YOUR NAME OF BAKERY) = MONGODB, LOCALY (ALSO REQUIRES TO CHANGE NAME OF BAKERY) = SQLITE PROBRABLY
    {

    }

    private void btnLoad_Clicked(object sender, EventArgs e) //LOAD BUTTON
    {

    }
}




//SOME MATERIAL
//https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/essential-syntax?view=net-maui-7.0








//TO DO 

//REPLACE SOME BUTTONS TO MENU
//FIND BETTER SPRITE FOR BUTTON
//ANIMATE CLICK
//CPS
//UPGRADES AND MODULES
//INFO WHEN MOUSE IS ON UPGRADE
//TRACK RUNTIME SINCE OPENNING THE GAME
//MAKE DARK MODE AND LIGHT MODE USABLE
//MAKE LESS VISIBLE TEXT OF VERSION
//LIST ALL UPGRADES IN INFO WHEN STABLE VERSION
//ANIMATE RAINING COOKIES IN BACKGROUND WHEN SOME CPS IS RUNNNING
//FIX ROUTE OF TEXT FILES FOR RANDOM NAMES
//WHEN CLICKED ON INFO IN MENU POPUP WINDOW WILL APPEAR INSTEAD OF GOING TO OTHER PAGE
//MULTIPLIER TO BUY OR SELL 1X,10X,100X OR SELL ALL
//ANIMATION FOR IOS WILL PROBABLY BE DONE IN SWIFT
//ANIMATION FOR EVERYTHING ELSE WILL MAYBE BE IN PYTHON OR SOMETHING
//?? CHANGE COLOR OF BACKGROUND ??
//MILK ANIMATION + HOW IT WORKS LIKE IN NORMAL CC
//FIT AROUND 5-7 MODULES, WHEN CURSORWILL BE IN THERE IF THERE IS MORE THAN 7 IT WILL DISPLAY EVERTHING HIDDEN
//UPGRADES AND MODULES WILL BE UNLOCKED AFTER A CERTAIN COOKIES WERE MADE
//CHANGE RADIUS OF BUTTON IF POSSIBLE WITH THIS SPRITE
//?? ACHIEVEMENTS ??
//DISPLAY HOW MANY UPGRADES WERE BOUGHT AND MODULES TOO
//MODULES WILL BE SORTD BY PRICE
// WHEN THERE WILL BE MORE THAN AROUND 5-7 UPGRADES SCROLL BAR WILL BE MADE
//?? ASCEND WITH CERAIN AMOUNT OF COOKIES MADE ??
//DESIGN FOR ANDROID AND IOS WILL BE REMADE IF IT WILL BE BAD 
//NOW I DONT KNOW ABOUT SELL 
//WHEN CHOSED TO LOAD FROM CLOUD USER MUST ENTER A NAME THAT HE/HER CHOSE FOR BAKERY 
//WHEN IN LIGHT MODE ALL TEXT WILL BE BLACK AND SAME FOR DARK MODE ALL TEXT WILL BE WHITE
//MAKE MY OWN ICON OR DOWNLOAD SOME AND CHANGE IT
//GOLDEN COOKIES WILL RANDOMLY APPER AND ADD SOME RANDOM SUM, SUM WILL BE BIGGER WHEN A CERTAIN AMOUNT OF COOKIES BE IN BANK OR MADE
//DETECT WHEN CHANGED TIME TO CHRISTMAS, PLAY SOME CHRISTMAS SONGS MAYBE, INSTEAD OF GOLDEN COOKIES WILL BE RAIDEERS, WINTER THEME, MAYBE A ACHEVEMENT IF BAKERY IF NAMED Claus's bakery
//DETECT IF THERE IS INPUT FROM KEYBOARD = autoclick OR autoc OR ac
