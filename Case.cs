using System;
using System.Collections.Generic;

 
namespace modele
{
    public class Case
    {
        //coordonnées 
        protected int lig;

        protected int col;
        public Boolean couloir, porte, escalier, noeud;
// suppression mur vierge et salle
        public Case()
        {
            lig = null;
            col = null;
            couloir = false;
            porte = false;
            escalier = false;
            noeud = false;
        }

        public int getLig()
        {
            return this.lig;
        }
        public void setLig(int var)
        {
            this.lig = var;
        }
        public int getCol()
        {
            return this.col;
        }
        public void setCol(int var1)
        {
            this.col = var1;
        }


    }

    public class CaseCouloir : Case
    {
        private Boolean itineraire;


        public CaseCouloir()
        {
            itineraire = false;
        }
        public Boolean getItin()
        {
            return this.itineraire;
        }
        public void setItin(Boolean var2)
        {
            this.itineraire = var2;
        }
    }

    public class CaseEscalier : Case
    {

    }
    public class CaseMur : Case
    {
    }
    public class CaseVierge : Case
    {
    }
    public class CaseSalle : Case
    {
        private string salle1;

        public CaseSalle()
        {
            salle1 = "NULL";
        }
        public string getSalle1()
        {
            return this.salle1;
        }
        public void setSalle1(string var3)
        {
            this.salle1 = var3;
        }
    }
    public class CasePorte : Case
    {
        private Boolean depart;

        private Boolean arrivee;

        private string salle2;

        public CaseCouloir entreeCouloir;

        public CasePorte()
        {
            depart = false;
            arrivee = false;
            salle2 = "NULL";
            entreeCouloir = new CaseCouloir();
        }
        public Boolean getDepart()
        {
            return this.depart;
        }
        public void setDepart(Boolean var4)
        {
            this.depart = var4;
        }

        public Boolean getArrivee()
        {
            return this.arrivee;
        }
        public void setArrivee(Boolean var4)
        {
            this.arrivee = var4;
        }

        public string getSalle2()
        {
            return this.salle2;
        }
        public void setSalle2(string var4)
        {
            this.salle2 = var4;
        }


    }

    public class CaseNoeud : Case
    {
        List<CaseNoeud> listVoisin = new List<CaseNoeud>();
        //voisin(liste noeud)
        public List<CaseNoeud> getVoisin()
        {
            return listVoisin;
        }
    }
}