using aptruc.Modèles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptruc.Modèles
{
    public class offres
    {
        private int id;
        private string name;
        private string description;
        private string jour;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Jour { get => jour; set => jour = value; }
        public offres(int id, string name, string description, string jour)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.jour = jour;
        }
    }
}


