using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        TEntity GetEntityById(long id);
        IList<TEntity> GetEntities();

    }
}
