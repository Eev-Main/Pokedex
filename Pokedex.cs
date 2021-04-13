using System;
using System.Collections.Generic;

namespace Pokedex
{
    class Pokedex
    {
        public List<Pokedexreg> listaPokemon = new List<Pokedexreg>();

        public Pokedex()
        {
            listaPokemon = new List<Pokedexreg>();
        }
        
        public Pokedexreg Consultar(int id)
        {
            for (int i = 0; i < listaPokemon.Count; i++)
            {
                if(listaPokemon[i].id == id)
                {
                    return listaPokemon[i];
                }
            }
            return null;
        }
    }
}