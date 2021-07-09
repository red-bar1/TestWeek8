using FinalFantasy.Core.Entities;
using FinalFantasy.RepositoryEF.Repositories;
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
            //MOCK
            //RepositoryGiocatoreMock repoGiocatore = new RepositoryGiocatoreMock();
            //EF
            RepositoryGiocatoreEF repoGiocatore = new RepositoryGiocatoreEF();

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
                    Giocatore giocatoreInserito = repoGiocatore.Add(giocatoreNuovo);
                    return giocatoreInserito;
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
            //MOCK
            //RepositoryGiocatoreMock repoGiocatore = new RepositoryGiocatoreMock();
            //EF
            RepositoryGiocatoreEF repoGiocatore = new RepositoryGiocatoreEF();
            RepositoryEroeEF repoEroe = new RepositoryEroeEF();

            Console.WriteLine("MENU DI GIOCO UTENTI NON ADMIN");
            Console.WriteLine("1. Gioca");
            Console.WriteLine("2. Crea nuovo Eroe");
            Console.WriteLine("3. Elimina Eroe");
            Console.WriteLine("4. Esci");

            int scelta = VerificaScelta(4);
            switch (scelta)
            {
                case 1:
                    Console.WriteLine("I tuoi Eroi:");
                    var giocatore1 = repoGiocatore.MostraEroi().FirstOrDefault(x => x.Nickname.Equals(giocatore.Nickname));
                    foreach (var eroi in giocatore1.Eroi)
                    {
                        Console.WriteLine(eroi);
                    }
                    return true;        
                case 2:
                    Eroe newEroe = repoEroe.Create();
                    bool esito = repoEroe.AddToGiocatore(newEroe, giocatore);
                    if (esito)
                    {
                        Console.WriteLine("Eroe inserito");
                    }
                    else
                    {
                        Console.WriteLine("Qualcosa è andato storto");
                    }
                    return true;
                case 3:
                    bool esito1 = repoEroe.Delete(giocatore);
                    if (esito1)
                    {
                        Console.WriteLine("Eroe Calcellato");
                    }
                    else
                    {
                        Console.WriteLine("Qualcosa è andato storto");
                    }
                    return true;
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
