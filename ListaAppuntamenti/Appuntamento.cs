using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    //classe
    internal class Appuntamento
    {
        //Attributi
        public DateTime dataAppuntamento = new DateTime();
        public string nomeAppuntamento;
        public string localitaAppuntamento;

        //costruttore
        public Appuntamento(DateTime dataAppuntamento , string nomeAppuntamento , string localitaAppuntamento)
        {

            this.dataAppuntamento = dataAppuntamento;
            this.nomeAppuntamento = nomeAppuntamento;   
            this.localitaAppuntamento = localitaAppuntamento;    

        }
        //Get e set

        public DateTime GetDataAppuntamento()
        {

            return dataAppuntamento;

        }
        public string GetNomeAppuntamento()
        {

            return nomeAppuntamento;

        }

        public string GetLocalitaAppuntamento()
        {

            return localitaAppuntamento;

        }

        public virtual void ToString()
        {


            Console.WriteLine("------------- Info Appuntamento ---------------");
            Console.WriteLine("Data appuntamento: " + dataAppuntamento);
            Console.WriteLine("Nome appuntamento: " + nomeAppuntamento);
            Console.WriteLine("Luogo appuntamento: " + localitaAppuntamento);
            Console.WriteLine("-----------------------------------------------");

        }


    }
}
