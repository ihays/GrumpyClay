using GrumpyClay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sculpture> SculpturesOfTheWeek { get; set; }
    }
}
