using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repositories;
using System;
using System.Collections.Generic;

namespace FinalFantasy.RepositoryMock
{
    public class RepositoryGiocatoreMock : IRepositoryGiocatore
    {

        private ICollection<Giocatore> Giocatori = new List<Giocatore>()
        {
            new Giocatore{Nickname = "Mario88"},
            new Giocatore{Nickname = "Giulia", Eroi = new List<Eroe>{
                new Eroe {
                    Nome="RedBaron",
                    Livello=1,
                    CategoriaEroe = CategoriaEroe.Wizard,
                    Arma = new Arma(){Nome= "Bastone Magico", Danno= 10}
                    },
                new Eroe
                {
                    Nome="Altro Eroe",
                    Livello =2,
                    CategoriaEroe = CategoriaEroe.Soldier,
                    Arma = new Arma(){Nome="Spada", Danno=10}
                }
                }
            }
        };

        public Giocatore Add(Giocatore item)
        {
            if(item != null)
            {
                foreach (Giocatore giocatore in Giocatori)
                {
                    if(giocatore.Nickname == item.Nickname)
                    {
                        Console.WriteLine("Esiste già questo Nickname");
                        return null;
                    }
                }
                Giocatori.Add(item);
                Console.WriteLine("Registrazione avvenuta con successo");
                return item;
            }
            else
            {
                Console.WriteLine("Non hai inserito nessun Nickname");
                return null;
            }
            
        }

        public Giocatore GetByNome(string nome)
        {
            if(nome != null)
            {
                foreach (Giocatore item in Giocatori)
                {
                    if(item.Nickname == nome)
                    {
                        return item;
                    }
                }
                Console.WriteLine("Nickname Errato");
                return null;
            }
            else
            {
                return null;
            }
        }

        //ho cambiato il metodo in corsa nelle repoEF
        public ICollection<Eroe> MostraEroi(Giocatore giocatore)
        {
            foreach (Eroe item in giocatore.Eroi)
            {
                Console.WriteLine(item);
            }
            return giocatore.Eroi;
        }

        //Metodo Aggiornato 
        public ICollection<Giocatore> MostraEroi()
        {
            throw new NotImplementedException();
        }
    }
}
