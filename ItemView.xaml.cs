namespace CALayerLeak;

public partial class ItemView
{
	//public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius), typeof(float), typeof(ItemView), 4f);

	public ItemView() => InitializeComponent();

	//public float CornerRadius
	//{
	//	get => (float)GetValue(CornerRadiusProperty);
	//	set => SetValue(CornerRadiusProperty, value);
	//}

	public float CornerRadius { get; set; } = 15f;
}
