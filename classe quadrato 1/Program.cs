using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_quadrato_1
{
    class Quadrato
    {
        private float lato;
        public float Lato
        {
            get { return lato; }
            set { lato = value; }
        }
        public Quadrato(float lato)
        {
            this.Lato = lato;
        }
    }
    

  
    
    internal class Program
    {
        static void Main(string[] args)
        {
            float lLato;
            Console.WriteLine("Inserisci la lunghezza del lato del quadrato:");
            
            if (float.TryParse(Console.ReadLine(), out lLato))
            {
                Quadrato quadrato = new Quadrato(lLato);
                Console.WriteLine("il lato del quadrato è:{0}", quadrato.Lato);
            }
            else
            {
                Console.WriteLine("Inserimento non valido. Assicurati di inserire un numero valido per il lato.");
            }
            Console.ReadLine();
        }
    }
}
