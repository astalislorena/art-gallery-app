using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models
{
    internal class Institution
    {
        private String name;
        private String location;
        private InstitutionType type;
        private Art[] arts;

        public Institution()
        {
            this.name = "";
            this.location = "";
            this.type = InstitutionType.Unknown;
            this.arts = new Art[1];
        }

        public Institution(String name, String location, InstitutionType type, Art[] arts)
        {
            this.name = name;   
            this.location = location;   
            this.type = type;
            this.arts = arts;
        }

        public String getName()
        {
            return this.name;
        }

        public String GetLocation()
        {
            return this.location;
        }

        public InstitutionType GetType()
        {
            return type;
        }

        public Art[] GetArts()
        {
            return arts;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetLocation(String location)
        {
            this.location = location;
        }

        public void SetType(InstitutionType type)
        {
            this.type = type;
        }

        public void SetArts(Art[] arts)
        {
            this.arts = arts;
        }
    }
}
