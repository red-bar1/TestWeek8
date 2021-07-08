using FinalFantasy.Core.Entities;
using FinalFantasy.RepositoryMock;
using System;

namespace FinalFantasy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RepositoryGiocatoreMock repoGiocatore = new RepositoryGiocatoreMock();
            Giocatore giocatore = Gaming.MenuIniziale();
            Console.WriteLine(giocatore);   
            if(giocatore != null)
            {
                bool esito = Gaming.MenuGiocatore(giocatore);
            }
            
            
        }
    }
}
