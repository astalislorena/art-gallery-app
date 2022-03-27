using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models.Persistance
{
    public class SculptureProvider
    {
        private readonly ArtGalleryDbContext _db;

        public SculptureProvider(ArtGalleryDbContext dbContext)
        {
            _db = dbContext;
        }
        public IQueryable<Sculpture> QueryPaitings() => _db.Sculptures.AsQueryable();

        public Sculpture AddSculpture(string title, string artistName, int year, string type)
        {
            Sculpture sculpture = new Sculpture(title, artistName, year, type);
            _db.Sculptures.Add(sculpture);
            _db.SaveChanges();
            return sculpture;
        }

        public Sculpture UpdateSculpture(int id, string title, string artistName, int year, string type)
        {
            Sculpture correspSculpt = _db.Sculptures.SingleOrDefault(p => p.Id == id);
            if (correspSculpt == null)
            {
                throw new Exception("Sculpture not found!");
            }
            correspSculpt.Title = title;
            correspSculpt.ArtistName = artistName;
            correspSculpt.Year = year;
            correspSculpt.Type = type;
            _db.SaveChanges();
            return correspSculpt;
        }

        public Sculpture GetSculptureById(int id)
        {
            try
            {
                return _db.Sculptures.SingleOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting sculpture: " + ex.ToString());
            }
        }

        public void DeleteSculptureById(int id)
        {
            try
            {
                _db.Sculptures.Remove(GetSculptureById(id));
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting sculptures: " + ex.ToString());
            }
        }
    }
}
