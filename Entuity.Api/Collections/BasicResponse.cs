namespace Entuity.Api.Collections;

public class BasicResponse<T>
{
	public IEnumerable<T> Items { get; set; } = [];

	public int Count { get; set; }
}
