using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repositories;
using FinalFantasy.RepositoryEF.Repositories;
using FinalFantasy.RepositoryMock;
using System;

namespace FinalFantasy
{
    class Program
    {
        static void Main(string[] args)
        {
            //MOCK
            //RepositoryGiocatoreMock repoGiocatore = new RepositoryGiocatoreMock();

            //EF
            RepositoryGiocatoreEF repoGiocatore = new RepositoryGiocatoreEF();

            Giocatore giocatore = Gaming.MenuIniziale();
            //Console.WriteLine(giocatore);   
            if(giocatore != null)
            {
                bool esito = Gaming.MenuGiocatore(giocatore);
                while (esito)
                {
                    esito = Gaming.MenuGiocatore(giocatore);
                }
            }
            
            
        }
    }
}
