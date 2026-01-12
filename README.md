🎮 Jogo de Adivinhação em C#
Este é um projeto simples desenvolvido em C# para fins de aprendizado. O objetivo do programa é desafiar o usuário a descobrir qual é o número secreto para conseguir encerrar a execução.

📋 Sobre o Projeto
O programa utiliza um laço de repetição while para manter o jogo ativo até que a condição de parada seja atingida. Ele inclui tratamentos básicos para garantir que o usuário insira apenas valores numéricos válidos.

Funcionalidades:
Loop Contínuo: O jogo não fecha até você acertar o número.

Validação de Entrada: O código utiliza int.TryParse para evitar erros caso o usuário digite letras ou símbolos.

Feedback em Tempo Real: Mensagens de erro ou sucesso dependendo da entrada do usuário.

🛠️ Tecnologias Utilizadas
.NET Core / .NET SDK

Linguagem C#

🕹️ Como Jogar
Ao iniciar, o console solicitará que você digite um número.

Se você digitar o número correto (0), o programa parabeniza você e encerra.

Se digitar qualquer outro número, o programa pedirá para tentar novamente.

Se digitar um texto inválido, o programa alertará para inserir um número válido.

Exemplo de Fluxo:
Adivinhe o número para encerrar o programa.
Digite um número: 5
Você errou! Tente novamente.
Digite um número: 0
Parabéns, você acertou o número!
📝 Licença
Este projeto é de uso livre para fins de estudo.
