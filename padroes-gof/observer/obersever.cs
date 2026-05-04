using System;
using System.Collections.Generic;

// 1. Interface Observer
public interface IAcompanhador {
    void Atualizar(string localizacao);
}

// 2. Subject (Interface ou Classe Base)
public abstract class CargaSujeito {
    private List<IAcompanhador> _observadores = new List<IAcompanhador>();

    public void Inscrever(IAcompanhador obs) => _observadores.Add(obs);
    public void Cancelar(IAcompanhador obs) => _observadores.Remove(obs);

    protected void Notificar(string localizacao) {
        foreach (var obs in _observadores) {
            obs.Atualizar(localizacao);
        }
    }
}

// 3. Concrete Subject
public class Carga : CargaSujeito {
    public string Nome { get; set; }
    private string _localizacaoAtual;

    public void MoverPara(string novaLocalizacao) {
        _localizacaoAtual = novaLocalizacao;
        Console.WriteLine($"\n[CARGA] {Nome} chegou em: {novaLocalizacao}");
        Notificar(novaLocalizacao);
    }
}

// 4. Concrete Observers
public class AppCliente : IAcompanhador {
    public void Atualizar(string local) => 
        Console.WriteLine($"[APP CLIENTE] Notificação Push: Sua carga está em {local}");
}

public class CentralRastreamento : IAcompanhador {
    public void Atualizar(string local) => 
        Console.WriteLine($"[LOGISTICA] Atualizando mapa global para: {local}");
}

// 5. Cliente (Main) - Uso Polimórfico
class Program {
    static void Main() {
        Carga cargaFrágil = new Carga { Nome = "Lote de Smartphones" };

        IAcompanhador cliente = new AppCliente();
        IAcompanhador logistica = new CentralRastreamento();

        // Registro dinâmico
        cargaFrágil.Inscrever(cliente);
        cargaFrágil.Inscrever(logistica);

        cargaFrágil.MoverPara("Porto de Santos");
        
        // Cancelamento em tempo de execução
        cargaFrágil.Cancelar(cliente); 
        
        cargaFrágil.MoverPara("Distribuidora Central");
    }
}