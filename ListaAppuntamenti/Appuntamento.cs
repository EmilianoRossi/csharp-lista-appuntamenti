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
        private protected DateTime dataAppuntamento = new DateTime();
        private protected string nomeAppuntamento;
        private protected string localitaAppuntamento;
        private protected DateTime dataAttuale = DateTime.Now;

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

        //override metodo tostring per stampare dati
        public virtual void ToString()
        {


            Console.WriteLine("------------- Info Appuntamento ---------------");
            Console.WriteLine("Data appuntamento: " + dataAppuntamento);
            Console.WriteLine("Nome appuntamento: " + nomeAppuntamento);
            Console.WriteLine("Luogo appuntamento: " + localitaAppuntamento);
            Console.WriteLine("-----------------------------------------------");

        }

        public DateTime CambiaData(DateTime dataUtente)
        {

            if (dataUtente < dataAttuale)
            {

                throw new InvalidOperationException("La data inserita è nel passato");
                return this.dataAppuntamento;

            }
            else if (dataUtente > dataAttuale)
            {

                this.dataAppuntamento = dataUtente;
                Console.WriteLine("La data inserita è stata aggiornata correttamente");
                return this.dataAppuntamento;

            }
            else
            {

                Console.WriteLine("La data inserita è quella attuale");
                return this.dataAppuntamento;

            }

        }


    }
}
