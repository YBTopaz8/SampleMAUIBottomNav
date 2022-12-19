using System.Diagnostics;

namespace MAUIBottomTabNav.Views;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


    protected override void OnAppearing()
    {
        base.OnAppearing();
		Debug.WriteLine("Main Page Appeared!");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        Debug.WriteLine("Navigated to Main Page!");
    }

    protected override void OnParentChanged()
    {
        base.OnParentChanged();

        Debug.WriteLine("Parent Changed sent from Main Page!");
    }
}

