using PotatoPortail.Models.eSports;

namespace PotatoPortail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Equipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipe()
        {
            Entraineurs = new HashSet<Entraineur>();
            Joueurs = new HashSet<Joueur>();
        }

        public int Id { get; set; }

        [Required]
        public string NomEquipe { get; set; }

        public int IdJeu { get; set; }

        public bool EstMonoJoueur { get; set; }

        public virtual Jeu Jeux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entraineur> Entraineurs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Joueur> Joueurs { get; set; }
    }
}
