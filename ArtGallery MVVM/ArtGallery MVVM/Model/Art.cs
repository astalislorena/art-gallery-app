using System.ComponentModel.DataAnnotations.Schema;


namespace ArtGallery_MVP.Models
{
    [Table("art")]
    public abstract class Art
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }

        public Art()
        {
            Title = "";
            ArtistName = "";
            Year = 0;
        }

        public Art(string title, string artistName, int year)
        {
            this.Title = title;
            this.ArtistName = artistName;
            this.Year = year;
        }


        public abstract string[] Convert();
    }
}
