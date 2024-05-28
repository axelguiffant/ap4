using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptruc.Modèles
{
    public class Constante
    {
        private Utilisateur courrantutil = new Utilisateur();

        public Utilisateur Courrantutil { get => courrantutil; set => courrantutil = value; }
    }
}
