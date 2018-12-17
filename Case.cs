using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace modele
{
    public class Case
    {
        //coordonnées 
        protected int lig;

        protected int col;
        public Boolean couloir, pt_cle, escalier, noeud;
// suppression mur vierge et salle
        public Case()
        {
            lig = null;
            col = null;
            couloir = false;
            pt_cle = false;
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
     
        public Boolean getCouloir
        {
            return this.couloir;
        }
        public void setCouloir(Boolean var2)
        {
            this.couloir = var2;
        }

        public Boolean getNoeud
        {
            return this.noeud;
        }
        public void setNoeud(Boolean var3)
        {
            this.noeud = var3;
        }

        public Boolean getEscalier
        {
            return this.escalier;
        }
        public void setEscalier(Boolean var4)
        {
            this.escalier = var4;
        }

        public Boolean getPtcle
        {
            return this.pt_cle;
        }
        public void setPtcle(Boolean var5)
        {
            this.pt_cle = var5;
        }



    }

    public class CaseCouloir : Case
    {


        public CaseCouloir():base()
        {
        }
       
    }

    public class CaseEscalier : Case
    { 
       public CaseEscalier():Base()
       {
       }

    }
    
  public class Pt_cle : Case
    {
        
       public Pt_cle():base()
        {
            
        }
        
    }

    public class Noeud : Case
    {
        public Noeud() : base()
        {

        }

    }
    
      

      
}
