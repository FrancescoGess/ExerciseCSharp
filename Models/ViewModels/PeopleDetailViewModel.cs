using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseCSharp.Models.ViewModels
{
    public class PeopleDetailViewModel : PeopleViewModel
    {
        public List<CarViewModel> Cars { get; set; }
        
    }
}