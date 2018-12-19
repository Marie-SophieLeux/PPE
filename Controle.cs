using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modele;

namespace controle
{
    public class Program
    {
        int nbCol, nbLig;
        List<(int index, string statut)> listCase;
        List<(int indCase, string indVoisin)> listVoisin;

        public static void Main()
        {
            Console.WriteLine("hello world");



        }
        // méthode qui initialise les grilles 
        public void initGrille()
        {
            listCase = new List<(int index, string statut)>();
            listVoisin = new List<(int indCase, string indVoisin)>();
        }

        public List<Case> creationGrille(List<(int index, string statut)> list)
        {
            List<Case> grille = new List<Case>();
            for (int i = 0; i < nbCol * nbLig; i++)
            {
                if (list.Contains((i,"cle")))
                {

                }
                else if (list.Contains((i,"couloir")))
                {

                }
                else if (list.Contains((i,"noeud")))
                {

                }
                else // cas où la case n'est pas utilisé dans le plan logique
                {

                }
            }
        }

    }
}