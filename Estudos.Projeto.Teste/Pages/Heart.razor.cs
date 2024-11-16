using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Estudos.Projeto.Teste.Pages;

public partial class Heart : ComponentBase
{
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeVoidAsync("fadeInScroll.applyFadeIn");
            await JsRuntime.InvokeVoidAsync("scrollToTop");
        }
    }
    
    private List<string> TextItems { get; set; } =
    [
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
    ];
    
    private List<string> ImageUrls { get; set; } =
    [
        "https://via.placeholder.com/100/FF5733",
        "https://via.placeholder.com/100/33FF57",
        "https://via.placeholder.com/100/3357FF",
        "https://via.placeholder.com/100/FFFF33",
        "https://via.placeholder.com/100/FF33FF"
    ];
}