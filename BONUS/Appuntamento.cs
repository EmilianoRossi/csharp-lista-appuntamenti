using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BONUS
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
        public Appuntamento(DateTime dataAppuntamento, string nomeAppuntamento, string localitaAppuntamento)
        {

            this.dataAppuntamento = dataAppuntamento;
            this.nomeAppuntamento = nomeAppuntamento;
            this.localitaAppuntamento = localitaAppuntamento;
            try
            {
                ControllaEccezioni();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

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
        //BONUS
        public string CambiaNome(string nomeUtente)
        {

            if (nomeUtente == nomeAppuntamento)
            {
                Console.WriteLine("Il nome dell'appuntamento è uguale al precedente");
                return this.nomeAppuntamento;

            }
            else
            {

                this.nomeAppuntamento = nomeUtente;
                Console.WriteLine("Il nome dell'appuntamento inserito è stata aggiornato correttamente");
                return this.nomeAppuntamento;

            }

        }

        public string CambiaLocalita(string localitàUtente)
        {

            if (localitàUtente == localitaAppuntamento)
            {
                Console.WriteLine("Il luogo dell'appuntamento è uguale al precedente");
                return this.localitaAppuntamento;

            }
            else
            {

                this.localitaAppuntamento = localitàUtente;
                Console.WriteLine("Il nome dell'appuntamento inserito è stata aggiornato correttamente");
                return this.localitaAppuntamento;

            }

        }

        public void ControllaEccezioni()
        {

            if (dataAppuntamento < dataAttuale)
            {

                throw new Exception("Data inserita è nel passato , errore");

            }

        }


    }
}
