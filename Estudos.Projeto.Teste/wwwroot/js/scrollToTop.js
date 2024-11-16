window.scrollToTop = function () {
    // Adiciona um pequeno atraso para garantir que o conteúdo esteja carregado antes de rolar
    setTimeout(function () {
        window.scrollTo(0, 0);
    }, 50); // Delay de 50 milissegundos
};