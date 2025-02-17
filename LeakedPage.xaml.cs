namespace CALayerLeak;

public partial class LeakedPage : ContentPage
{
	public LeakedPage()
	{
		InitializeComponent();
		BindingContext = new LeakedViewModel();
	}
}
