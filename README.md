# Gestão de Equipamentos
![](https://i.imgur.com/VPIzq42.gif)
## Introdução 
O Projeto Gestão de Equipamentos, é um sistema simulado a um armazém de equipamentos e gerenciamento de chamados  
## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)
## Detalhes
O sistema conta com dois ambientes, dos equipamentos e dos chamados, onde em cada um é possível adicionar, editar, visualizar e excluir 

## Funcionalidades
**Adicionar** - O usuário consegue adicionar equipamentos e chamados, com suas características

**Id's** - Os equipamentos e chamados contam com Id's únicos, assim evitando a chance de conflito no sistema  

**Número de Série** - Os equipamentos contam com números de série para melhorar a identificação e organização para o usuário

**Visualizar** - É possivel visualizar uma lista dos equipamentos e chamados já existentes, assim facilitando a compreensão do usuário

**Editar** - Caso o usuário deseje, é possível editar um chamado ou equipamento já existente

**Excluir** - Caso o usuário deseje, é possível excluir um chamado ou equipamento já existente

## Requisitos para uso
.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto

## Como utilizar
Clone o Repositório
```
git clone https://github.com/bernardo-dos-santos/GestaoDeEquipamentos
```
Navegue até a pasta raiz da solução
```
cd GestaoDeEquipamentos
```
Restaure as dependências
```
dotnet restore
```
Navegue até a pasta do projeto
```
cd GestaoDeEquipamentos.ConsoleApp
```
Execute o projeto
```
dotnet run
```