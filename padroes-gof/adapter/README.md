## Nome do padrão
Adapter

## Categoria
Padrão Estrutural

## Objetivo
Permitir que classes com interfaces incompatíveis trabalhem juntas.

## Problema Motivador
Uma loja virtual possui diferentes sistemas de pagamento, porém cada um utiliza métodos diferentes de integração. O sistema principal espera uma interface padrão, mas os serviços externos possuem implementações incompatíveis.

## Solução
O padrão Adapter cria uma classe intermediária responsável por converter a interface dos sistemas externos para o formato esperado pela aplicação principal.

## Estrutura do Projeto
 - Cliente
 - Target
 - Adapter
 - Adaptee

## Vantagens
 - Reutilização de código legado
 - Baixo acoplamento
 - Facilidade de integração entre sistemas diferentes

## Linguagem Utilizada
Python