using Microsoft.AspNetCore.Components;

namespace BlazorWebApplication1
{
	public interface ITab
	{
		RenderFragment ChildContent { get; }
	}
}