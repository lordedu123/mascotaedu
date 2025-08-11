using System;
using System.ComponentModel.DataAnnotations;

namespace mascotaedu.Models
{

    public class Pet
    {
        public int Id { get; set; }

        public String? Name { get; set; }

        public String? Type { get; set; }

        public int Age { get; set; }


    }

}