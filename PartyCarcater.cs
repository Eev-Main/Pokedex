using System;


namespace Pokedex
{
    class PartyCaracter:Pokedexreg
    {
        public enum Genero
        {
            MACHO,
            HEMBRA,
            INDEFINIDO
        }
        public Genero genero;

        public PartyCaracter(string nombre, int id, Genero genero) : base(nombre, id)
        {

            this.nombre = nombre;
            this.id = id;
            this.genero = genero;

        }
    }
}