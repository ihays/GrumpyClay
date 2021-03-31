using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.Models
{
    public class SculptureRepository : ISculptureRepository
    {
        private readonly AppDbContext _appDbContext;
        public SculptureRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Sculpture> AllSculptures
        {
            get
            {
                return _appDbContext.Sculptures.Include(c => c.Category);
            }
        }

        public IEnumerable<Sculpture> SculpturesOfTheWeek
        {
            get
            {
                return _appDbContext.Sculptures.Include(c => c.Category).Where(s => s.IsSculptureOfTheWeek);
            }
        }

        public Sculpture GetSculptureById(int sculptureId)
        {
            return _appDbContext.Sculptures.FirstOrDefault(s => s.SculptureId == sculptureId);
        }
    }
}
