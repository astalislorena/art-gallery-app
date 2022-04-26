using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVC.Model
{
    [Table("instutution")]
    public class Institution
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Painting> Paintings { get; set; }
        public virtual ICollection<Sculpture> Sculptures { get; set; }

        public Institution()
        {
            this.Id = 0;
            this.Name = "";
            this.Location = "";
            this.Paintings = new List<Painting>();
            this.Sculptures = new List<Sculpture>();
        }
    }
}
