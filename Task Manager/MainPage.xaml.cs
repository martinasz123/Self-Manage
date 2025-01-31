namespace Task_Manager;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


	private async void ProjectAddBtn(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new AddProjectPage());
	}
}

