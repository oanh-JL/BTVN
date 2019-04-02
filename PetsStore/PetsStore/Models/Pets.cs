using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetsStore.Models
{
    public class Pets
    {
        public static List<Pet> getPets()
        {
            var tamp = new dataContext();
            return tamp.Pets.ToList();
        }
    }
}