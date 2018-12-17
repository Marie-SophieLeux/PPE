using System;
using System.Collections.Generic;


namespace modele
{
    public class Plan // plan logique
    {
        private int nbCol, nbLig;
        // grille contenant la liste des cases
        List<Case> grille;

        // constructeur
        public Plan()
        {
            nbCol = null;
            nbLig = null;  
            grille = new List<Case>();
        }
        // dans le cas d'une recherche avec point de départ et d'arrivée
        public Plan(int nbCol, int nbLig, List<Case> grille)
        {
            this.nbCol = nbCol;
            this.nbLig = nbLig;  
            this.grille = grille; 
        }

        public List<ListNoeud> rechercheItiNoeud(CaseNoeud depart, CaseNoeud arrivee)
        {
            // contient liste de tous les itinéraires possibles
            List<ListNoeud> listeList = new List<ListNoeud>();
            List<CaseNoeud> listCaseNoeudDep = depart.getVoisin();
            List<CaseNoeud> listCaseNoeudAr = arrivee.getVoisin();
 
            // taille de la liste de noeud de la case départ, on suppose que dans tous les cas la valeur est toujours de 2, chaque couloir 2 noeuds
            int n = listCaseNoeudDep.Count;
            // nombre d'éléments dans la liste des listes
            int m = 0;

            // création de liste selon le nombre de noeuds de départ
            // ajout de ces listes dans la liste des listes
            for (int i = 0; i < n; i++)
            {
                ListNoeud liste = new ListNoeud();
                liste.getListe().Add(listCaseNoeudDep[i]);
                listeList.Add(liste);
                m = listeList.Count;
            }
            // boolean vérifiant sur les derniers éléments sont ceux de la destination
            Boolean check;
            // acquisition des différents itinéraires de noeuds possibles
            while (check == false)
            {
                // // liste de transition
                List<ListNoeud> listeTran = new List<ListNoeud>();
                for (int i = 0; i < listeList.Count; i++)
                {
                    // liste qui contient les caseNoeuds de 1 itinéraire
                    ListNoeud liste = listeList[i];
                    // vérifie si la liste est terminé
                    if (liste.getStatus() == false)
                    {
                        // t: index du dernier élément de la liste en cours
                        int t = liste.getListe().Count;
                        CaseNoeud c = liste.getListe()[t - 1];
                        // prends en liste les voisins du dernier point
                        List<CaseNoeud> voisins = c.getVoisin();
                        // boucle qui va considérer chaque voisin et va les ajouter à la liste s'il correspond aux critères
                        // critère: différents des case départs et des caseNoeuds déjà contenus dans la liste
                        for (int j = 0; j < voisins.Count; j++)
                        {
                            // case qui est voisin
                            CaseNoeud v = voisins[j];
                            //
                            if ((liste.Contains(v) == true)&&(listCaseNoeudDep.Contains(v) == true))
                            {

                            }

                            // si la dernière caseNoeud est l'arrivée
                            if (listCaseNoeudAr.Contains(v))
                            {
                                
                            }
                        }
                    } else {
                        listeTran.Add(liste);
                    }
                    
                }
                listeList = listeTran;
                check = true;
                // si 1 seul élément n'est pas fini alors la boucle continue
                for (int l = 0; l < listeList.Count; l++)
                {
                    if (listeList[l].getStatus() == false)
                    {
                        check = false;
                    }
                }
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

    }


    // la classe liste de noeud a été créée pour créer une liste de liste 
    public class ListNoeud
    {
        // liste de noeud d'un possilbe itinéraire
        private List<CaseNoeud> liste;
        private Boolean statusFinis;
        //constructeur
        public ListNoeud()
        {
            list = new List<CaseNoeud>();
            statusFinis = false;
        }

        // méthode qui retourne la liste de noeud
        public List<CaseNoeud> getListe()
        {
            return liste;
        }

        public Boolean getStatus()
        {
            return statusFinis;
        }

        public void setStatus(Boolean status)
        {
            statusFinis = status;
        }

    }

    // --------------------------------------------------------
    
}


