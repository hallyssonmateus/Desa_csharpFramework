# Simulator Télos - Nível #6

## Descrição do Projeto

Este projeto é parte de um jogo de aventura em 2D, intitulado "Simulator Télos", focado na criação de inimigos dinâmicos e interessantes, que proporcionem uma experiência desafiadora e envolvente para os jogadores. O objetivo principal é implementar uma estrutura de classes para representar inimigos do jogo, utilizando conceitos de **Programação Orientada a Objetos** (POO). A classe `Enemy` serve como a base para diferentes tipos de inimigos, enquanto subclasses específicas implementam comportamentos únicos para cada tipo de inimigo.

## Estrutura de Classes

### 1. **Classe Base: Enemy**

A classe `Enemy` é a classe pai que contém atributos e métodos comuns a todos os inimigos no jogo. Ela possui os seguintes atributos e métodos:

#### Atributos:
- `health`: A saúde do inimigo, representada por um valor numérico.
- `velocity`: A velocidade de movimento do inimigo.

#### Métodos:
- **`receiveDamage(damage)`**: Método que reduz a saúde do inimigo ao receber dano.
- **`displayStatus()`**: Exibe o estado atual do inimigo, como sua saúde e velocidade.
- **`move()`**: Método que movimenta o inimigo. Este método pode ser sobrescrito pelas subclasses para comportamentos específicos.
- **`isDead()`**: Verifica se a saúde do inimigo chegou a zero.

### 2. **Subclasses de Enemy**

Foram criadas algumas subclasses de inimigos que herdam os métodos da classe `Enemy` e implementam comportamentos específicos para cada tipo de inimigo.

#### 2.1. **Classe EnemyWithAttack**
- **Descrição**: Representa inimigos que podem atacar o personagem principal.
- **Atributos adicionais**: `attack` (representa o poder de ataque do inimigo).
- **Métodos**:
  - **`attackPlayer(damage)`**: Executa o ataque no jogador, causando dano.

#### 2.2. **Classe FlyingEnemy**
- **Descrição**: Representa inimigos que voam.
- **Atributos adicionais**: `altitude` (representa a altitude em que o inimigo voa).
- **Métodos**:
  - **`fly()`**: Executa o voo do inimigo, alterando sua posição no cenário.

#### 2.3. **Classe JumpingEnemy**
- **Descrição**: Representa inimigos que podem saltar.
- **Atributos adicionais**: `altitude` (representa a altura do salto).
- **Métodos**:
  - **`jump()`**: Executa o salto do inimigo, alterando sua posição no cenário.

#### 2.4. **Classe StealthyEnemy**
- **Descrição**: Representa inimigos que podem ficar invisíveis.
- **Métodos**:
  - **`invisible()`**: Executa a invisibilidade do inimigo, tornando-o invisível para o jogador.

## Requisitos e Implementação

### 1. **Encapsulamento**
- **Critério**: Os atributos `health` e `velocity` são acessados apenas por meio de métodos específicos, como `receiveDamage()` e `displayStatus()`. A modificação direta desses atributos é evitada, garantindo maior controle sobre o estado do inimigo.
- **Implementação**: Todos os atributos são privados e só podem ser acessados ou modificados através de métodos públicos ou propriedades controladas.

### 2. **Herança**
- **Critério**: A classe `Enemy` serve como classe base para todas as subclasses de inimigos. As subclasses podem herdar e sobrescrever métodos da classe `Enemy` conforme necessário.
- **Implementação**: As subclasses como `EnemyWithAttack`, `FlyingEnemy`, `JumpingEnemy` e `StealthyEnemy` herdam os métodos de `Enemy`, mas podem sobrescrevê-los ou adicionar novos comportamentos específicos.

### 3. **Polimorfismo**
- **Critério**: Diferentes tipos de inimigos devem ser tratados de maneira genérica, mas com comportamentos específicos.
- **Implementação**: O método `move()` pode ser chamado para qualquer instância de `Enemy` ou suas subclasses, mas seu comportamento pode variar dependendo do tipo de inimigo (por exemplo, `FlyingEnemy` voa, `JumpingEnemy` pula).

### 4. **Abstração**
- **Critério**: A classe `Enemy` abstrai os comportamentos comuns a todos os inimigos, como mover, receber dano e verificar se está morto. As subclasses implementam comportamentos específicos.
- **Implementação**: A classe `Enemy` não contém detalhes de comportamentos específicos (como regeneração de vida ou esquiva), mas fornece uma estrutura básica que as subclasses podem estender e personalizar.


## Como Usar

1. Clone o repositório ou baixe os arquivos.
2. Abra o projeto em um ambiente de desenvolvimento C# (como o Visual Studio ou Visual Studio Code).
3. Compile e execute o arquivo `Program.cs` para testar os comportamentos dos inimigos.
4. Instâncias das classes `Enemy`, `EnemyWithAttack`, `FlyingEnemy`, `JumpingEnemy`, e `StealthyEnemy` podem ser criadas e seus métodos podem ser invocados para verificar os comportamentos.

## Exemplo de Execução

```csharp
Enemy enemy1 = new Enemy(100, 5.0f);
enemy1.displayStatus();
enemy1.receiveDamage(20);
enemy1.displayStatus();

EnemyWithAttack enemy2 = new EnemyWithAttack(100, 4.0f, 15);
enemy2.displayStatus();
enemy2.attackPlayer(20);
enemy2.displayStatus();
