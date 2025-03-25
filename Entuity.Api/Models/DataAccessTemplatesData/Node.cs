namespace Entuity.Api.Models.DataAccessTemplatesData;
/// <summary>
/// Holds a collection of key value pairs that represent named nodes and their corresponding data
/// <para>See <a href='https://support.entuity.com/hc/en-us/articles/13830443905565-Data-Access-Templates-Management-Operations-on-a-Single-Template-RESTful-API#get'/></para>
/// </summary>
public class Node : Dictionary<string, NodeData>;
