using System;
using System.Collections.Generic;


namespace modele
{
    public class Plan // plan logique
    {
        // nom de la salle de départ et d'arrivée
        string depart, arrivee;
        // objet case qui correspond respectivement à la salle de départ et d'arrivée
        CaseNoeud caseDepart, caseArrivee;
        // grille contenant la liste des cases
        List<Case> grille;

        // constructeur
        public Plan()
        {
            depart = null;
            arrivee = null;
            caseDepart = new CaseNoeud();
            caseArrivee = new CaseNoeud();
            grille = new List<Case>();
        }
        // dans le cas d'une recherche avec point de départ et d'arrivée
        public Plan(string dep, string arr)
        {
            depart = dep;
            arrivee = arr;
            caseDepart = new CaseNoeud();
            caseArrivee = new CaseNoeud();
        }

        public List<ListNoeud> rechercheItiNoeud()
        {
            List<ListNoeud> listeList = new List<ListNoeud>();
            List<CaseNoeud> listCaseNoeudDep = new List<CaseNoeud>();
            List<CaseNoeud> listCaseNoeudAr = new List<CaseNoeud>();
            setCaseDep(depart);
            setCaseAr(arrivee);
            listCaseNoeudDep = caseDepart.getVoisin();
            listCaseNoeudAr = caseArrivee.getVoisin();
            // taille de la liste de noeud de la case départ, on suppose que dans tous les cas la valeur est toujours de 2, chaque couloir 2 noeuds
            int n = listCaseNoeudDep.Count;
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                ListNoeud liste = new ListNoeud();
                liste.getListe().Add(listCaseNoeudDep[i]);
                listeList.Add(liste);
                m = listeList.Count;
            }

            while (m != n)
            {
                n = m;
                // liste de transition
                List<ListNoeud> listeTran = new List<ListNoeud>();
                for (int i = 0; i < n; i++)
                {
                    ListNoeud liste = listeList[i];
                    //ListNoeud l = new ListNoeud();

                    int t = liste.getListe().Count;
                    CaseNoeud c = liste.getListe()[t - 1];
                    if ((compareCase(c, listCaseNoeudAr[0]) == false) && (compareCase(c, listCaseNoeudAr[1]) == false))
                    {
                        // obtenir la liste des voisins du dernier élément de la liste puis les comparer aux éléments présents de la liste
                    }
                    else
                    {
                        listeTran.Add(liste);
                    }
                }

                listeList = listeTran;
                m = listeList.Count;
            }
            // méthode qui verifie si tous les ititnéraires possibles arrivent à destination
            return listeList;
        }



        public List<CaseCouloir> itiFinal()
        {
            List<CaseCouloir> iti = new List<CaseCouloir>();

            return iti;
        }

        public Boolean compareCase(Case c1, Case c2)
        {
            if ((c1.getCol() == c2.getCol()) && (c1.getLig() == c2.getLig()))
            {
                return true;
            }
            return false;
        }

        // méthode pour voir si le point de départ est dans le même couloir que le point d'arrivée
        public CaseNoeud getCaseDep()
        {
            return caseDepart;
        }

        public CaseNoeud getCaseArr()
        {
            return caseArrivee;
        }

        // setter pour la case correpondant au départ, de la même manière que pour l'arrivee
        public void setCaseDep(string dep)
        {
            //     foreach (Case c in grille)
            //     {
            //         if (c.)
            //     }
        }

        public void setCaseAr(string arr)
        {
            //     foreach (Case c in grille)
            //     {
            //         if (c.)
            //     }
        }




    }


    // la classe liste de noeud a été créée pour créer une liste de liste 
    public class ListNoeud
    {
        // liste de noeud d'un possilbe itinéraire
        private List<CaseNoeud> list;

        //constructeur
        public ListNoeud()
        {
            list = new List<CaseNoeud>();
        }

        // méthode qui retourne la liste de noeud
        public List<CaseNoeud> getListe()
        {
            return list;
        }
    }

    // --------------------------------------------------------
    
}


