using System;
using System.Linq;

namespace ArtGallery_MVP.Models.Persistance
{
    public class PaintingProvider
    {
        private readonly ArtGalleryDbContext _db;

        public PaintingProvider(ArtGalleryDbContext dbContext)
        {
            _db = dbContext;
        }
        public IQueryable<Painting> QueryPaitings() => _db.Paintings.AsQueryable();

        public Painting AddPaitning(string title, string artistName, int year, string type, string technique)
        {
            Painting painting = new Painting(title, artistName, year, type, technique);
            _db.Paintings.Add(painting);
            _db.SaveChanges();
            return painting;
        }

        public Painting UpdatePainting(int id, string title, string artistName, int year, string type, string technique)
        {
            Painting correspPaint = _db.Paintings.SingleOrDefault(p => p.Id == id);
            if (correspPaint == null)
            {
                throw new Exception("Painting not found!");
            }
            correspPaint.Title = title;
            correspPaint.ArtistName = artistName;
            correspPaint.Year = year;
            correspPaint.Type = type;
            correspPaint.Technique = technique;
            _db.SaveChanges();
            return correspPaint;
        }

        public Painting GetPaintingById(int id)
        {
            try
            {
                return _db.Paintings.SingleOrDefault(p => p.Id == id);
            } 
            catch(Exception ex)
            {
                throw new Exception("Error getting painting: " + ex.ToString());
            }
        }

        public void DeletePaintingById(int id)
        {
            try
            {
                _db.Paintings.Remove(GetPaintingById(id));
                _db.SaveChanges();
            } catch(Exception ex)
            {
                throw new Exception("Error deleting painting: " + ex.ToString());
            }
        }

    }
}
