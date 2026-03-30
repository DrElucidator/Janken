```markdown
# Janken Console App

Este é um jogo de **Pedra, Papel e Tesoura** desenvolvido em C#.  
O programa roda no console e permite que o jogador dispute várias rodadas contra o computador, com placar atualizado a cada partida.

---

## Estrutura do Projeto

O projeto é composto por três arquivos principais:

### 1. `Program.cs`
- Ponto de entrada da aplicação.
- Controla o loop principal do jogo.
- Exibe cabeçalho e placar.
- Chama o método `Game.PlayRound()` para executar cada rodada.
- Atualiza as estatísticas de vitórias, derrotas e empates.
- Pergunta ao jogador se deseja continuar ou encerrar.

### 2. `Game.cs`
- Contém a lógica principal do jogo.
- Solicita a jogada do usuário (pedra, papel ou tesoura).
- Valida a entrada do jogador.
- Gera a jogada do computador de forma aleatória usando `RandomNumberGenerator`.
- Determina o resultado da rodada (vitória, derrota ou empate).
- Retorna o resultado para ser contabilizado no placar.

### 3. `UI.cs`
- Responsável pela interface com o usuário no console.
- Métodos principais:
  - `Header()`: limpa a tela e exibe a mensagem inicial.
  - `Standings()`: mostra o placar atualizado (jogador, computador e empates).
  - `Retry()`: pergunta se o jogador deseja continuar ou encerrar o jogo.

---

## Como Executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/DrElucidator/Janken.git
   ```
2. Acesse a pasta do projeto:
   ```bash
   cd janken-console-app
   ```
3. Compile e execute:
   ```bash
   dotnet run
   ```

---

## Funcionalidades

- Escolha da jogada por número ou palavra (`1` ou `pedra`, `2` ou `papel`, `3` ou `tesoura`).
- Jogada do computador gerada aleatoriamente.
- Resultado exibido imediatamente após cada rodada.
- Placar acumulado de vitórias, derrotas e empates.
- Opção de jogar novamente ou encerrar.

---

## Exemplo de Uso

```
Bem vindo ao jogo de pedra, papel e tesoura!

Aperte ENTER para iniciar...

Placar atual:
Jogador: 0
Computador: 0
Empates: 0

Escolha sua jogada:
1 para pedra;
2 para papel;
3 para tesoura;
ou digite a palavra correspondente.

Você escolheu pedra!
O computador escolheu tesoura
Você ganhou!

Pressione ENTER para jogar novamente ou qualquer outra tecla para sair
```

---

## Observações

- O jogo é totalmente executado no console.
- Não há dependências externas além do .NET SDK.
- O código está organizado em três classes para separar responsabilidades: lógica (`Game`), interface (`UI`) e controle (`Program`).