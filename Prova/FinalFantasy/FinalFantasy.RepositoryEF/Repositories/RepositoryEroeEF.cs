using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF.Repositories
{
    public class RepositoryEroeEF : IRepositoryEroe
    {
        public Personaggio Add(Personaggio item)
        {
            throw new NotImplementedException();
        }

        public bool AddToGiocatore(Eroe newEroe, Giocatore giocatore)
        {
            using(var ctx = new FinalFantasyContext())
            {
                if (newEroe != null)
                {
                    try
                    {
                        newEroe.Giocatore = giocatore;
                        Arma armaEroe = ctx.Arma.Find(newEroe.ArmaNome);
                        newEroe.Arma = armaEroe;
                        ctx.Entry<Eroe>(newEroe).State = EntityState.Added;
                                              
                        ctx.SaveChanges();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
                return false;
            }
        }

        public Eroe Create()
        {
            Eroe newEroe = new Eroe();
            Console.WriteLine("Inserisci il nome dell'eroe");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il numero corrispondente alla categoria dell'eroe:");
            Console.WriteLine("1. Soldier");
            Console.WriteLine("2. Wizard");
            bool check = Int32.TryParse(Console.ReadLine(), out int categoria);
            while (!check || categoria<0 || categoria>2)
            {
                Console.WriteLine("Scegli tra le opzioni.");
                Console.WriteLine("Inserisci il numero corrispondente alla categoria dell'eroe:");
                Console.WriteLine("1. Soldier");
                Console.WriteLine("2. Wizard");
                check = Int32.TryParse(Console.ReadLine(), out categoria);
            }
            switch (categoria)
            {
                case 1:
                    CategoriaEroe categoriaEroe1 = CategoriaEroe.Soldier;
                    Console.WriteLine("Inserisci il numero corrispondente all'arma che vuoi usare:");
                    Console.WriteLine("1. Ascia");
                    Console.WriteLine("2. Mazza");
                    Console.WriteLine("3. Spada");
                    bool check1 = Int32.TryParse(Console.ReadLine(), out int categoriaArmaSoldier);
                    while(!check1 || categoriaArmaSoldier<0 || categoriaArmaSoldier > 3)
                    {
                        Console.WriteLine("Scegli tra le opzioni.");
                        Console.WriteLine("Inserisci il numero corrispondente all'arma che vuoi usare:");
                        Console.WriteLine("1. Ascia");
                        Console.WriteLine("2. Mazza");
                        Console.WriteLine("3. Spada");
                        check1 = Int32.TryParse(Console.ReadLine(), out categoriaArmaSoldier);
                    }
                    switch (categoriaArmaSoldier)
                    {
                        case 1:
                            string nomeArma1 = "Ascia";
                            newEroe.Nome = nome;
                            newEroe.CategoriaEroe = categoriaEroe1;
                            newEroe.ArmaNome = nomeArma1;
                            break;
                        case 2:
                            string nomeArma2 = "Mazza";
                            newEroe.Nome = nome;
                            newEroe.CategoriaEroe = categoriaEroe1;
                            newEroe.ArmaNome = nomeArma2;
                            break;
                        case 3:
                            string nomeArma3 = "Spada";
                            newEroe.Nome = nome;
                            newEroe.CategoriaEroe = categoriaEroe1;
                            newEroe.ArmaNome = nomeArma3;
                            break;
                    }
                    break;
                case 2:
                    CategoriaEroe categoriaEroe2 = CategoriaEroe.Wizard;
                    Console.WriteLine("Inserisci il numero corrispondente all'arma che vuoi usare:");
                    Console.WriteLine("1. Arco e frecce");
                    Console.WriteLine("2. Bacchetta");
                    Console.WriteLine("3. Bastone Magico");
                    bool check2 = Int32.TryParse(Console.ReadLine(), out int categoriaArmaWizard);
                    while (!check2 || categoriaArmaWizard < 0 || categoriaArmaWizard > 3)
                    {
                        Console.WriteLine("Scegli tra le opzioni.");
                        Console.WriteLine("Inserisci il numero corrispondente all'arma che vuoi usare:");
                        Console.WriteLine("1. Arco e frecce");
                        Console.WriteLine("2. Bacchetta");
                        Console.WriteLine("3. Bastone Magico");
                        check1 = Int32.TryParse(Console.ReadLine(), out categoriaArmaWizard);
                    }
                    switch (categoriaArmaWizard)
                    {
                        case 1:
                            string nomeArma1 = "Arco e frecce";
                            newEroe.Nome = nome;
                            newEroe.CategoriaEroe = categoriaEroe2;
                            newEroe.ArmaNome = nomeArma1;
                            break;
                        case 2:
                            string nomeArma2 = "Bacchetta";
                            newEroe.Nome = nome;
                            newEroe.CategoriaEroe = categoriaEroe2;
                            newEroe.ArmaNome = nomeArma2;
                            break;
                        case 3:
                            string nomeArma3 = "Bastone Magico";
                            newEroe.Nome = nome;
                            newEroe.CategoriaEroe = categoriaEroe2;
                            newEroe.ArmaNome = nomeArma3;
                            break;
                    }
                    break;
                    
            }
            return newEroe;
        }

        public bool Delete(Giocatore giocatore)
        {
            RepositoryGiocatoreEF repoGiocatore = new RepositoryGiocatoreEF();
            using (var ctx = new FinalFantasyContext())
            {
                    try
                    {
                        Giocatore giocatore1 = repoGiocatore.MostraEroi().FirstOrDefault(x => x.Nickname.Equals(giocatore.Nickname));
                        Console.WriteLine("Inserisci il nome dell'eroe da eliminare");
                        string nome = Console.ReadLine();
                        Eroe eroeToDelete = ctx.Eroi.Find(nome);
                        ctx.Entry<Eroe>(eroeToDelete).State = EntityState.Deleted;
                        ctx.SaveChanges();
                    return true;
                }
                    catch (Exception)
                    {

                        throw;

                    }
                
            }
        }

        public Personaggio GetByNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
