using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ColorRepository : EfEntityRepositoryBase<Color, ProjectDbContext>, IColorRepository
    {
        public ColorRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}
