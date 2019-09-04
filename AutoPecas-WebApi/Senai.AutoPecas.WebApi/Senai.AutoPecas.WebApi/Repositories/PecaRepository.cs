using Senai.AutoPecas.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.AutoPecas.WebApi.Repositories
{
    public class PecaRepository
    {
        public List<Pecas> Listar()
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Pecas.ToList();
            }
        }

        public void Pecas(Pecas peca)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                ctx.Pecas.Add(peca);
                ctx.SaveChanges();
            }
        }

        //BUSCAR POR ID
        public Pecas BuscarPorId(int id)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Pecas.FirstOrDefault(x => x.PecaId == id);
            }
        }

        //ATUALIZAR
        public void Atualizar(Pecas peca)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                Pecas PecaBuscada = ctx.Pecas.FirstOrDefault(x => x.PecaId == peca.PecaId);

                PecaBuscada.Nome = peca.Nome;

                ctx.Pecas.Update(PecaBuscada);

                ctx.SaveChanges();
            }
        }

        //FALTA FAZER O DELETAR







    }
}
