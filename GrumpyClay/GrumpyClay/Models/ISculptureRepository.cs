using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.Models
{
    public interface ISculptureRepository
    {
        IEnumerable<Sculpture> AllSculptures { get; }
        IEnumerable<Sculpture> SculpturesOfTheWeek { get; }
        Sculpture GetSculptureById(int sculptureId);

    }
}
