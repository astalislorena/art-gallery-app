using ArtGallery_MVP.Models;
using System.Collections.Generic;

namespace ArtGallery_MVP.View.Staff
{
    internal interface IVizStaff 
    {
        List<string[]> Staff { set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Selected { get; }
    }
}
