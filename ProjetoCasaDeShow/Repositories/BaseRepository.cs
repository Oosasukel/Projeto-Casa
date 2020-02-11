using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly AppContext contexto;
        protected DbSet<T> dbSet;

        public BaseRepository(AppContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}