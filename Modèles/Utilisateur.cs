﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptruc.Modèles
{
    public class Utilisateur
    {
        private int id;
        private string nom;
        private string prenom;
        private int points;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Points { get => points; set => points = value; }
    }
}
