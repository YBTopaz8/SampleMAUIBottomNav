using System.Diagnostics;

namespace MAUIBottomTabNav.Views;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Debug.WriteLine("First Page Appeared!");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Debug.WriteLine("Navigated to First Page!");
    }

    protected override void OnParentChanged()
    {
        base.OnParentChanged();

        Debug.WriteLine("Parent Changed sent from First Page!");
    }
}