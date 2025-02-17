namespace CALayerLeak;

internal class LeakedViewModel
{
	public IEnumerable<int> Items { get; } = Enumerable.Range(0, 50);
}
