using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseCSharp.Models.ViewModels;
using ExerciseCSharp.Models.Services.Application;

// using ExerciseCSharp.Models.PeopleDetailViewModels;

namespace ExerciseCSharp.Models.Services.Application
{
    public class PeopleService
    {
        public List<PeopleViewModel> GetPeople()
        {

            var peopleList = new List<PeopleViewModel>();
            var rand = new Random();
            for (int i = 0; i <= 5; i++)
            {
                var people = new PeopleViewModel
                {
                    Id = i,
                    Name = "Nome",
                    Surname = "Cognome"
                };
                peopleList.Add(people);
            }
            return peopleList;
        }

        public PeopleDetailViewModel GetPeopleDetail(int id)
        {
            var person = new PeopleDetailViewModel();

            if (person == null)
            {
                return null; // o return new PersonDetail();
            }


            var personDetail = new PeopleDetailViewModel
            {
                Id = person.Id,
                Name = person.Name,
                Surname = person.Surname,
                // Mappare altre proprietà se necessario
                Cars = new List<CarViewModel>()
            };

            var rand = new Random();
            for (int i = 0; i <= 5; i++)
            {
                var car = new CarViewModel
                {
                    Brand = "Brand",
                    Targa = "Targa",
                };
                personDetail.Cars.Add(car);
            }

            return personDetail;
        }
    }
}
