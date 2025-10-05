using UnityEngine;

public class Goblin : Enemigo, IAtacable, IDropeable
{
    public Goblin(string nombre, int vida, int ataque) : base(nombre, vida, ataque) { }

    public override void HabilidadEspecial()
    {
        Debug.Log(Nombre + " usa Furia Goblin: duplica su ataque por 1 turno!");
    }

    public void Atacar(Enemigo enemigo)
    {
        Debug.Log(Nombre + " ataca a " + enemigo.Nombre + " causando " + Ataque + " de da�o.");
        enemigo.RecibirDa�o(Ataque);
    }

    public void DropearItem()
    {
        Debug.Log(Nombre + " solt� una poci�n menor.");
    }
}