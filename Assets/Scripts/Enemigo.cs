using UnityEngine;

public abstract class Enemigo
{
  
    private string nombre;
    private int vida;
    private int ataque;

    public Enemigo(string nombre, int vida, int ataque)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.ataque = ataque;
    }

    public virtual void RecibirDa�o(int cantidad)
    {
        vida -= cantidad;
        Debug.Log(nombre + " recibi� " + cantidad + " de da�o. Vida restante: " + vida);
    }

    public abstract void HabilidadEspecial();

    public string Nombre { get { return nombre; } }
    public int Vida { get { return vida; } set { vida = value; } }
    public int Ataque { get { return ataque; } set { ataque = value; } }
}