using Entuity.Api.Interfaces;

namespace Entuity.Api.Models.Collections;

/// <summary>
/// Defines a list of items that can be returned from the API.
/// </summary>
/// <typeparam name="T"></typeparam>
public class ListResponse<T> : List<T> where T : IReturnItem;

