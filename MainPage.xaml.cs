namespace CALayerLeak
{
	public partial class MainPage : ContentPage
	{
		public MainPage() => InitializeComponent();

		private async void OnNavigateClicked(object sender, EventArgs e) => await Shell.Current.Navigation.PushAsync(new LeakedPage());

		private void OnCollectClicked(object sender, EventArgs e)
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}
	}
}
