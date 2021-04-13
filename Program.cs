using System;
using System.Collections.Generic;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex lista = new Pokedex();

            //pokedex 

            Pokedexreg Pikachu = new Pokedexreg("pikachu", 25);
            Pokedexreg Eevee = new Pokedexreg("Eevee", 133);
            Pokedexreg Vaporeon = new Pokedexreg("Vaporeon", 134);
            Pokedexreg Jolteon = new Pokedexreg("Jolteon", 135);
            Pokedexreg Flareon = new Pokedexreg("Flareon", 136);
            Pokedexreg Espeon = new Pokedexreg("Espeon", 196);
            Pokedexreg Umbreon = new Pokedexreg("Umbreon", 197);
            Pokedexreg Leafeon = new Pokedexreg("Leafeon", 470);
            Pokedexreg Glaceon = new Pokedexreg("Glaceon", 471);
            Pokedexreg Sylveon = new Pokedexreg("Sylveon", 700);

            lista.listaPokemon.Add(Pikachu);
            lista.listaPokemon.Add(Eevee);
            lista.listaPokemon.Add(Vaporeon);
            lista.listaPokemon.Add(Jolteon);
            lista.listaPokemon.Add(Flareon);
            lista.listaPokemon.Add(Espeon);
            lista.listaPokemon.Add(Umbreon);
            lista.listaPokemon.Add(Leafeon);
            lista.listaPokemon.Add(Glaceon);
            lista.listaPokemon.Add(Sylveon);

            //party

            PartyCaracter RegPikachu = new PartyCaracter(Pikachu.nombre, Pikachu.id, PartyCaracter.Genero.HEMBRA);
            PartyCaracter RegEevee = new PartyCaracter(Pikachu.nombre, Pikachu.id, PartyCaracter.Genero.MACHO);
            PartyCaracter RegJolteon = new PartyCaracter(Pikachu.nombre, Pikachu.id, PartyCaracter.Genero.MACHO);
            PartyCaracter RegEspeon = new PartyCaracter(Pikachu.nombre, Pikachu.id, PartyCaracter.Genero.HEMBRA);
            PartyCaracter RegGlaceon = new PartyCaracter(Pikachu.nombre, Pikachu.id, PartyCaracter.Genero.HEMBRA);
            PartyCaracter RegSylveon = new PartyCaracter(Pikachu.nombre, Pikachu.id, PartyCaracter.Genero.HEMBRA);

            Party listaParty = new Party();    
            listaParty.Equipo.Add(RegPikachu);
            listaParty.Equipo.Add(RegEevee);
            listaParty.Equipo.Add(RegJolteon);
            listaParty.Equipo.Add(RegEspeon);
            listaParty.Equipo.Add(RegGlaceon);
            listaParty.Equipo.Add(RegSylveon);
            
          Console.WriteLine("Pokemon A LOT OF EEVEE´s Version");
        }
    }
}
