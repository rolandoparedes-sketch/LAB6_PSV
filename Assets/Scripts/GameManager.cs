using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Goblin goblin;
    private Orco orco;
    private PocionVida pocion;

    void Start()
    {
        goblin = new Goblin("Goblin Verde", 50, 10);
        orco = new Orco("Orco Brutal", 100, 20, 15);

        pocion = new PocionVida("Poción de Vida", 25);

        Debug.Log("=== INICIO DEL COMBATE ===");

        goblin.HabilidadEspecial();
        orco.HabilidadEspecial();

        goblin.Atacar(orco);
        orco.Atacar(goblin);

        pocion.Consumir(goblin);

        goblin.DropearItem();

        Debug.Log("=== FIN DEL COMBATE ===");
    }
}