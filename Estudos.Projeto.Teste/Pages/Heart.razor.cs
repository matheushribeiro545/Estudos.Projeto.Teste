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
    
    private Random random = new Random();
    
    private List<string> TextItems { get; } =
    [
        "O moizin todo feliz ta passando aqui pra dizer que te ama muito, e relembrar um pouco da nossa história e sentimentos incríveis.",
        "Lembra da primeira vez que saímos? A vidazinha toda com vergonha e o moii todo feliz e empolgado. Eu pegando na sua mão, todo com o jeitinho pra você não 'perceber' rsrs. E não posso esquecer, no dia 12/10/2023 foi a primeira vez que você disse que gostava de mim (indiretamente, mas disse kk)",
        "O Grande Dia! Quando a vidazinha aceitou iniciar uma nova história com o mor, mesmo sabendo das dificuldades que enfrentaríamos, seguiu firme e confiante. (\ud83d\udc40aliança que o moii dizia ser 'pequena')",
        "Depois de 10 dias, finalmente o moii e a vida conseguiram se abraçar e ficar grudinho. Mas tava um calor imenso e sem luz pra ligar o ventilador kkk.",
        "Essa vez eu não consigo esquecer kk. O moizin foi ver a vida antes dos 15 dias que seu pai tinha dito, então tava cagando de medo rsrs. Foi gostoso esse dia, porque eu não tava esperando ficar grudinho com a vida. (\ud83d\ude33 moizin esqueceu o instrumento nesse dia)",
        "A primeira vez que o mor viu a vida com essa roupa, quase perdi o ar rsrs. Além de deixar o moii perdido, algum tempo depois dessa foto a vidazinha disse o primeiro 'Te Amo'. Eu sendo devagar, como sempre, não tinha entendido a mensagem\ud83d\ude0a.",
        "O desenho que a vida fez do moizin e o texto que veio na camisa que a vida deu de presente para o moii. Segundo a vidazinha, o desenho não ficou legal, mas foi o suficiente pra deixar o moii perdido e emocionado\u2764\ufe0f.",
        "Aquele dia... O dia em que o moizin viu a vidazinha criança toda empolgada, com muita alegria em Cabreúva. Como eu amei ver você assim, tão feliz e alegre.",
        "Vidazinha e moizin tocando juntinho, uma delicia. Achávamos que isso aconteceria apenas depois do casamento, mas o moii deu um jeito.",
        "Moii e vida super feliz. Uma das fotos que o moizin mais ama ver, porque você ta com um sorriso TÃO gostoso, que automáticamente tira outro sorriso meu.",
        "O dia em que foi possível sentir a cumplicidade através dos lábios, mas não com palavras. A sensação incrível de sentir o amor de outra forma...",
        "Bem, essa foto me deixa sem palavras... O dia em que passamos para a etapa 2 de 3. Ver a vidazinha emocionada foi incrível.",
        "O senso de improviso da vida e do mor é incrível. Conseguimos comemorar nosso 1 ano de namoro a distância mesmo, comendo um lanchinho e dando bastante risada.",
        "O moizin todo confiante, porque a vida é incrível e fez a autoestima do mor aumentar um montão. Ai fico se achando um tanto kkk",
        "E com essa imagem do moizin criança encerro a sessão de fotinhas. Por que o moii criança? Bem, é porque a vidazinha conseguiu resgatar o Matheus doce e feliz que eu sempre amei, mas estava perdido lá no fundo."
    ];
    
    private List<string> ImageUrls { get; } =
    [
        "img/IMG-20241120-WA0066.jpg",
        "img/IMG-20241120-WA0071.jpg",
        "img/IMG-20241120-WA0070.jpg",
        "img/IMG-20241120-WA0045.jpg",
        "img/IMG-20241120-WA0047.jpg",
        "img/IMG-202411-006.jpg",
        "img/IMG-20241120-WA0073.jpg",
        "img/IMG-20241120-WA0053.jpg",
        "img/IMG-20241120-WA0072.jpg",
        "img/IMG-20241120-WA0062.jpg",
        "img/IMG-20241120-WA0061.jpg",
        "img/IMG-20241120-WA0063.jpg",
        "img/IMG-20241120-WA0065.jpg",
        "img/IMG-202411-001.jpg",
        "img/IMG-20241120-WA0046.jpg"
    ];
    
    private List<string> ImageRandom { get; } =
    [
        "img/IMG-20241118-WA0049.jpg",
        "img/IMG-20241118-WA0064.jpg",
        "img/IMG-20241120-WA0056.jpg",
        "img/IMG-20241120-WA0057.jpg",
        "img/IMG-20241120-WA0058.jpg",
        "img/IMG-20241120-WA0059.jpg",
        "img/IMG-20241120-WA0060.jpg",
        "img/IMG-20241120-WA0061-1.jpg",
        "img/IMG-20241120-WA0062-1.jpg",
        "img/IMG-20241120-WA0063-1.jpg",
        "img/IMG-20241120-WA0064.jpg",
        "img/IMG-202411-005.jpg",
        "img/IMG-202411-004.jpg",
        "img/IMG-202411-003.jpg",
        "img/IMG-202411-002.jpg",
        "img/IMG-20241118-WA0057.jpg",
        "img/IMG-20241120-WA0068.jpg",
        "img/IMG-20241120-WA0069.jpg"
    ];
}