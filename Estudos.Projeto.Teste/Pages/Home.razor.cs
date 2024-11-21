using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Estudos.Projeto.Teste.Pages;

public partial class Home : ComponentBase
{
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeVoidAsync("fadeInScroll.applyFadeIn");
            await JsRuntime.InvokeVoidAsync("scrollToTop");
        }
    }
    
    private void GoToNextPage()
    {
        Navigation.NavigateTo("Estudos.Projeto.Teste/Heart");
    }
}