## Nome do padrão
Observer

## Categoria
Padrão Comportamental

## Objetivo
Permitir que múltiplos objetos sejam notificados automaticamente quando houver mudança de estado em outro objeto.

## Problema Motivador
Uma empresa de logística precisa acompanhar a localização de cargas em tempo real.
Diversos sistemas (como aplicativo do cliente e central de rastreamento) precisam ser atualizados sempre que a carga muda de posição.
Sem um padrão adequado, o sistema ficaria fortemente acoplado e difícil de manter, pois cada atualização exigiria alterações diretas em vários componentes.

## Solução
O padrão Observer define uma relação de dependência entre objetos, onde um objeto principal (Subject) mantém uma lista de observadores e os notifica automaticamente sempre que seu estado muda.

## Estrutura do Projeto
 - IAcompanhador (Observer): Interface dos observadores
 - CargaSujeito (Subject): Gerencia os observadores
 - Carga (Concrete Subject): Objeto observado (carga)
 - AppCliente (Observer): Observador do cliente
 - CentralRastreamento (Observer): Observador da logística

## Vantagens
 - Baixo acoplamento entre os componentes
 - Facilidade para adicionar novos observadores
 - Atualizações automáticas e dinâmicas
 - Código mais organizado e escalável

## Linguagem Utilizada
C#
