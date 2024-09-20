# PedraPapelTesoura
## Atividade 01 | Crie um jogo de Pedra Papel Tesoura

`### 1 É um jogo de Pedra Papel Tesoura feito em C# e .NET usando o Visual Studio Code.`

É informado as opções para jogar, o usuário precisa digitar a sua escolha entre **pedra** **papel** e **tesoura**.

![Captura de tela 2024-09-20 180841](https://github.com/user-attachments/assets/99b73e96-d864-4bbb-8219-f6e7a79646b2)

No exemplo a baixo tanto a **máquina** tanto o **jogador** escolheram a mesma opção resultando em **empate**. **0 pontos adicionados**.

![Captura de tela 2024-09-20 180852](https://github.com/user-attachments/assets/3d341fda-aa29-48c2-9be2-3664e35f9f3c)

O jogo repete ate o jogador **ganhar** da máquina.

![Captura de tela 2024-09-20 180902](https://github.com/user-attachments/assets/29aac513-50a1-4271-ac71-76d09f7bb1cc)

Quando o **jogador** ganha o jogo é finalizado, é mostrado a pontuação dos 2 jogadores e é perguntado se quer **jogar novamente**.

![Captura de tela 2024-09-20 180923](https://github.com/user-attachments/assets/96f9b929-f1cf-4ceb-bfed-f67c24cb1f98)

Caso o usuário insira **"S"** o jogo será reiniciado.

![Captura de tela 2024-09-20 180932](https://github.com/user-attachments/assets/15e549e2-13a4-464e-9394-98af66c0c2aa)

Caso seja inserido **"N"** o jogo é finalizado.

![Captura de tela 2024-09-20 181001](https://github.com/user-attachments/assets/3f40f33f-7016-4cef-83ca-dcc3ffc14ec4)

`#Código`

É inicializado uma uma variável bool **repetirjogo** com valor em verdadeiro *true*, e duas variáveis inteiras **(pontosusuario e pontosmaquina)** com valor em **0**.

![Captura de tela 2024-09-20 183213](https://github.com/user-attachments/assets/25e61836-a310-419e-b545-4f72c1a82e99)

Cria uma estrutura de *while* com repetirjogo, para se a condição for verdadeira vai ser executado o bloco de código. è armazenado em string (EscolhaDoUsuario) a escolha do usuario. Dentro do bloco de codigo é inserido as opções do jogo. é criado tbm um **Random** e um **,Next()** com valores entre 1 e 4.

![Captura de tela 2024-09-20 183228](https://github.com/user-attachments/assets/353842ee-7439-45f0-95ae-4ee7d52899ae)

É criado uma estrutura de switch para (escolhadousuario). Com 3 cases é definido em if() as opções que o usuario pode escolher, cada um tem uma opção de empate, vitoria do usuario ou vitoria da maquina contado 1 ponto em cada vitória.

![Captura de tela 2024-09-20 183232](https://github.com/user-attachments/assets/08b8fdbc-a1e3-41c1-b996-3656a6e3bf8a)
![Captura de tela 2024-09-20 183251](https://github.com/user-attachments/assets/e662dc50-567f-4dc4-bee5-fb54c85c8fa9)
![Captura de tela 2024-09-20 183258](https://github.com/user-attachments/assets/d46e15d0-4fe1-434d-a0da-7df2ec3db800)

Quando o usuário vence o jogo é finalizado, dentro da estrutura do while e inicializado um if() com **repetir == false** para o jogo para, mostra a pontuação e pergunta se quer jogar novamente. Caso sim outra estrutura do if() é inicializado, se inserido "S" o jogo reinicia, se inserido "N" o jogo para.

![Captura de tela 2024-09-20 183303](https://github.com/user-attachments/assets/31c21a66-03c8-4f6a-afd8-bb0f8d9d51dc)




