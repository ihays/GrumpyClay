using GrumpyClay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.ViewModels
{
    public class SculpturesListViewModel
    {
        public IEnumerable<Sculpture> Sculptures { get; set; }
        public string CurrentCategory { get; set; }
    }
}
