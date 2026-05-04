package singleton;
class ControleVolume {

    private static ControleVolume instancia;
    private int volume;

    // Construtor privado
    private ControleVolume() {
        volume = 30; // valor inicial
    }

    // Método que retorna a única instância
    public static ControleVolume getInstance() {
        if (instancia == null) {
            instancia = new ControleVolume();
        }
        return instancia;
    }

    // Getter e Setter
    public int getVolume() {
        return volume;
    }

    public void setVolume(int volume) {
        this.volume = volume;
    }
}
public class TesteSingleton {
    public static void main(String[] args) {

        ControleVolume v1 = ControleVolume.getInstance();
        ControleVolume v2 = ControleVolume.getInstance();

        System.out.println("Volume inicial:");
        System.out.println("v1: " + v1.getVolume());
        System.out.println("v2: " + v2.getVolume());

        System.out.println("\nAlterando volume usando v1...");
        v1.setVolume(80);

        System.out.println("\nDepois da alteração:");
        System.out.println("v1: " + v1.getVolume());
        System.out.println("v2: " + v2.getVolume());
    }
}