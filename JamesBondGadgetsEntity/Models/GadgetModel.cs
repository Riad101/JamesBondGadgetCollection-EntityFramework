using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JamesBondGadgetsEntity.Models
{
    public class GadgetModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DisplayName("Appears in this Movie")]
        public string AppearsIn { get; set; }
        [Required]
        [DisplayName("Actor's Name")]
        public string WithThisActor { get; set; }

        public GadgetModel()
        {
            Id = -1;
            Name = "Nothing";
            Description = "Nothing Yet";
            AppearsIn = "Nowhere";
            WithThisActor = "With No one";
        }

        public GadgetModel(int id, string name, string description, string appearsIn, string withThisActor)
        {
            Id = id;
            Name = name;
            Description = description;
            AppearsIn = appearsIn;
            WithThisActor = withThisActor;
        }
    }
}