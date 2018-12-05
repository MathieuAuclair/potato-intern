﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ApplicationPlanCadre.Models;

namespace ApplicationPlanCadre.ViewModels
{
    public class servicesAdaptesViewModel:ViewModelBase
    {
        [DisplayAttribute(Name = "Section")]
        public virtual IEnumerable<NomSection> NomSections { get; set; }
        public virtual string titreSection { get; set; }
        public virtual IEnumerable<ContenuSection> contenuSection { get; set; }
        [DisplayAttribute(Name = "Contenu")]
        public virtual string texteContenu { get; set; }
        public PlanCours planCours { get; set; }
        public int idPlanCours { get; set; }
        [DisplayAttribute(Name = "Discipline")]
        public virtual IEnumerable<Departement> Departements { get; set; }
        public virtual int discipline { get; set; }
        public virtual string nom { get; set; }
    }
}