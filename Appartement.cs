
namespace wa.entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Appartement")]
    public class Appartement : AuditableEntity<int>
    {
        public int OrdreAffichage { get; set; }

        public int LexiqueAppartement_Id { get; set; }
        [ForeignKey("LexiqueAppartement_Id")]
        public virtual LexiqueAppartement LexiqueAppartement { get; set; }

        [ForeignKey("Id")]
        [Required]
        public virtual ProduitElement ProduitElement { get; set; }


        [InverseProperty("ProduitRelation")]
        public virtual IEnumerable<ProduitElement> ProduitElements { get; set; }

    }
}
