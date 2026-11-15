namespace Entuity.Api.Test;

internal static class TestAddresses
{
	public static string V4(byte first, byte second, byte third, byte fourth)
		=> $"{first}.{second}.{third}.{fourth}";
}
