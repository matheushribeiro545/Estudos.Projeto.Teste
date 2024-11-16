window.fadeInScroll = {
    applyFadeIn: () => {
        const elements = document.querySelectorAll('.fade-in');
        const handleScroll = () => {
            elements.forEach(element => {
                const rect = element.getBoundingClientRect();
                const windowHeight = window.innerHeight;

                if (rect.top <= windowHeight - 50) {  // Se o elemento está a 50px ou menos da borda inferior da janela
                    element.classList.add('show');
                }
            });
        };

        window.addEventListener('scroll', handleScroll);
        handleScroll(); // Chama a função ao carregar a página
    }
};

// Iniciar o efeito quando a página carregar
document.addEventListener('DOMContentLoaded', (event) => {
    fadeInScroll.applyFadeIn();
});