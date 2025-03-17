namespace Entuity.Api.Models.GetItems;


public class GlobalPasswordComplexitySettings
{
	public int PwdHistoryLimit { get; set; }

	public int PwdMinLength { get; set; }

	public bool PwdReqNumeric { get; set; }

	public bool PwdReqLowerCase { get; set; }

	public bool PwdReqUpperCase { get; set; }

	public bool PwdReqSpecial { get; set; }

	public bool PwdReqOTP { get; set; }
}

