using FinalFantasy.Core.Entities;
using FinalFantasy.RepositoryMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class Gaming
    {
        
        //MENU INIZIALE DI GESTIONE DELL'UTENTE
        public static Giocatore MenuIniziale()
        {
            RepositoryGiocatoreMock repoGiocatore = new RepositoryGiocatoreMock();
            int scelta = 0;

            Console.WriteLine("1. Accedi");
            Console.WriteLine("2. Registrati");
            Console.WriteLine("3. Esci");
            
            scelta = VerificaScelta(3);

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Inserisci il Nickname");
                    string nickname = Console.ReadLine();
                    return repoGiocatore.GetByNome(nickname);
                case 2:
                    Console.WriteLine("Inserisci il Nickname con cui ti vuoi registrare");
                    string nicknameNew = Console.ReadLine();
                    while(nicknameNew == "")
                    {
                        Console.WriteLine("Inserisci un Nickname valido");
                        nicknameNew = Console.ReadLine();
                    }
                    Giocatore giocatoreNuovo = new Giocatore() { Nickname = nicknameNew };
                    repoGiocatore.Add(giocatoreNuovo);
                    return giocatoreNuovo;
                case 3:
                    Console.WriteLine("Alla prossima partita");
                    break;
            }
            return null;

        }

        public static int VerificaScelta(int sceltaMax)
        {
            bool check = Int32.TryParse(Console.ReadLine(), out int scelta);
            while (!check || scelta < 1 || scelta > sceltaMax)
            {
                Console.WriteLine("Scegli tra le opzioni");
                check = Int32.TryParse(Console.ReadLine(), out scelta);
            }
            return scelta;
        }

        //MENU PRINCIPALE DI INIZIO PARTITA
        public static bool MenuGiocatore(Giocatore giocatore)
        {
            RepositoryGiocatoreMock repoGiocatore = new RepositoryGiocatoreMock();
            //ALL'INTERNO DI QUESTO MENU VADO A GESTIRE LE OPERAZIONI
            //INIZIALE DI CREAZIONE PARTITA
            //CREAZIONE EROE
            //SCELTA EROE
            //ELIMINARE EROE
            Console.WriteLine("MENU DI GIOCO UTENTI NON ADMIN");
            Console.WriteLine("1. Gioca");
            Console.WriteLine("2. Crea nuovo Eroe");
            Console.WriteLine("3. Elimina Eroe");
            Console.WriteLine("4 Esci");

            int scelta = VerificaScelta(4);
            switch (scelta)
            {
                case 1:
                    ICollection<Eroe> eroiGiocatore = repoGiocatore.MostraEroi(giocatore);
                    return true;
                    
                case 2:
                    return false;
                case 3:
                    return false;
                case 4:
                    return false;
            }
            return false;
        }

        public static void Partita(Eroe eroeScelto)
        {
            //METODO ALL'INTERNO DEL QUALE VADO A GESTIRE 
            //LA LOGICA RELATIVA AD UNA PARTITA
            throw new NotImplementedException();
        }

        public static void Battaglia(Eroe eroeScelto, Mostro mostroSorteggiato)
        {
            //ALL'INTERNO DI QUESTO METODO VENGONO GESTITE LE CASISTICHE DI 
            //VITTORIA-PERDITA DELL'EROE
            //LA BATTAGLIA SI RIPETE FINCHE' L'EROE NON UCCIDE IL MOSTRO O VICEVERSA
            throw new NotImplementedException();
        }

        public static bool SceltaTurno(Eroe eroe, Mostro mostro)
        {
            //METODO CHE CHIEDE ALL'UTENTE QUALE MOSSA ESEGUIRE
            //LOTTA O FUGA
            throw new NotImplementedException();
        }
    }
}
