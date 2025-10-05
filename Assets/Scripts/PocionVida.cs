using UnityEngine;

public abstract class Item
{
    private string nombre;

    public Item(string nombre)
    {
        this.nombre = nombre;
    }

    public string Nombre { get { return nombre; } }
}

public class PocionVida : Item, IConsumible
{
    private int curacion;

    public PocionVida(string nombre, int curacion) : base(nombre)
    {
        this.curacion = curacion;
    }

    public void Consumir(Enemigo enemigo)
    {
        enemigo.Vida += curacion;
        Debug.Log(enemigo.Nombre + " usa " + Nombre + " y recupera " + curacion + " de vida.");
    }
}