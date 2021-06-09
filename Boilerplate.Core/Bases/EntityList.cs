using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Core.Bases
{
    public class EntityList<TEntity>
    {
        public EntityList(int totalItens, List<TEntity> itens)
        {
            TotalItens = totalItens;
            PaginatedItens = itens;
        }

        public int TotalItens{ get; protected set; }
        public List<TEntity> PaginatedItens { get; }
    }
}
