namespace Entuity.Api;

public class Response<T> where T : Entity
{
	public required ICollection<T> Items { get; set; }

	public int Count { get; set; }
}