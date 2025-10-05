using UnityEngine;

public class Orco : Enemigo, IAtacable
{
    private int defensa;

    public Orco(string nombre, int vida, int ataque) : base(nombre, vida, ataque)
    {
        this.defensa = 10;
    }

    public Orco(string nombre, int vida, int ataque, int defensa) : base(nombre, vida, ataque)
    {
        this.defensa = defensa;
    }

    public override void HabilidadEspecial()
    {
        Debug.Log(Nombre + " usa Piel de Hierro, aumentando su defensa en " + defensa);
    }

    public void Atacar(Enemigo enemigo)
    {
        Debug.Log(Nombre + " golpea con fuerza orca!");
        enemigo.RecibirDaño(Ataque);
    }
}