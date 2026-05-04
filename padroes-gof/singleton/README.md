## Nome do padrão
Singleton

## Categoria
Padrão Criacional

## Objetivo
Garantir que uma classe tenha apenas uma única instância e fornecer um ponto global de acesso a ela.

## Problema Motivador
Em um sistema, pode ser necessário controlar um recurso compartilhado, como o volume de um dispositivo.
Se múltiplas instâncias forem criadas, podem ocorrer inconsistências, pois cada objeto teria seu próprio estado de volume.

## Solução
O padrão Singleton restringe a criação de instâncias de uma classe, garantindo que apenas uma exista durante toda a execução do programa.

Isso é feito pelo:
 - Construtor privado
 - Atributo estático para armazenar a instância
 - Método público que retorna essa instância única

## Estrutura do Projeto
 - ControleVolume (Singleton): Classe que controla a única instância
 - TesteSingleton (Cliente): Classe que utiliza o Singleton

## Vantagens
 - Controle global de acesso à instância
 - Evita duplicação de recursos
 - Consistência de dados compartilhados
 - Fácil acesso à instância única

## Linguagem Utilizada
Java
