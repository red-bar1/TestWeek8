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
    public class RepositoryGiocatoreEF : IRepositoryGiocatore
    {
       
        public Giocatore Add(Giocatore item)
        {
            using(var ctx = new FinalFantasyContext())
            {
                try
                {
                    if(item == null)
                    {
                        Console.WriteLine("Inserimento non valido");
                    }

                    Giocatore giocatore = ctx.Giocatori.Find(item.Nickname);
                    if (giocatore != null)
                    {
                        Console.WriteLine("Nickname già esistente");
                    }
                    else
                    {
                        ctx.Entry<Giocatore>(item).State = EntityState.Added;
                        ctx.SaveChanges();
                        Console.WriteLine("Registrazione avvenuta con successo");
                        return item;
                    }
                }
                catch(SqlException ex)
                {
                    Console.WriteLine(ex.Message);

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return null;
                
            }
        }

        public Giocatore GetByNome(string nome)
        {
            using(var ctx = new FinalFantasyContext())
            {
                Giocatore giocatore;

                if (nome != "")
                {
                    giocatore = ctx.Giocatori.FirstOrDefault(g => g.Nickname==nome);
                    if(giocatore == null)
                    {
                        Console.WriteLine("Nickname Errato");
                    }
                }
                else
                {
                    Console.WriteLine("Nickname vuoto");
                    giocatore = null;
                }
                return giocatore;
            }
        }

        public ICollection<Giocatore> MostraEroi()
        {
            using(var ctx = new FinalFantasyContext())
            {
                return ctx.Giocatori.Include(x => x.Eroi).ToList();
            }
        }
    }
}
