import random
from abc import ABC, abstractmethod

class ProcessadorPagamento(ABC):
    @abstractmethod
    def realizar_pagamento(self, valor: float, forma: str) -> None:
        pass

class NovoServicoExternoAPI:
    def autorizar_transacao(self, quantia_centavos: int, metodo: str) -> bool:
        print(f"   [API Externa] Meio: {metodo} | Valor: R$ {quantia_centavos/100:.2f}")
        print(f"   [API Externa] Validando comunicação com banco...")
        return True

    def confirmar_recebimento(self) -> None:
        print("   [API Externa] Transação concluída e recibo gerado.")

class AdapterPagamento(ProcessadorPagamento):
    def __init__(self, servico_externo: NovoServicoExternoAPI):
        self._servico_externo = servico_externo

    def realizar_pagamento(self, valor: float, forma: str) -> None:
        valor_em_centavos = int(round(valor * 100))
        # O adaptador traduz a "forma" interna para o "metodo" da API
        sucesso = self._servico_externo.autorizar_transacao(valor_em_centavos, forma)
        if sucesso:
            self._servico_externo.confirmar_recebimento()

def executar_checkout(processador: ProcessadorPagamento):
    formas_disponiveis = ["Crédito", "Débito", "Pix"]
    
    valor_aleatorio = round(random.uniform(10.0, 500.0), 2)
    forma_aleatoria = random.choice(formas_disponiveis)
    
    print(f"Sistema Loja: Processando venda de R$ {valor_aleatorio} via {forma_aleatoria}...")
    processador.realizar_pagamento(valor_aleatorio, forma_aleatoria)
    print("Sistema Loja: Checkout finalizado com sucesso.\n")

if __name__ == "__main__":
    api_moderna = NovoServicoExternoAPI()
    meu_adaptador = AdapterPagamento(api_moderna)
    
    for i in range(3):
        print(f"--- Venda #{i+1} ---")
        executar_checkout(meu_adaptador)