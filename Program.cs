using System;

namespace _esercizio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creazione classi");

            Atleta atleta1 = new Atleta("Mario", "Rossi", 18, "Calcio", "annuale");
            atleta1.GetMonthlyPayment(atleta1.Iscrizione, atleta1.SetMonthlyPayment());


    
        }
    }

    class Atleta
    {
        public string Name;
        public string SurName;
        public int Age;
        public string Sport;
        public string Iscrizione;

        public Atleta(string name, string surName, int age, string sport, string iscrizione)
        {
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
            this.Sport = sport;
            this.Iscrizione = iscrizione;
        }

        public void GetIntroduction()
        {
            Console.WriteLine("Nome: " + Name + "; Cognome: " + SurName + "; Età: " + Age + "; Sport: " + Sport + ";");
        }

        public void GetMonthlyPayment(string iscrizione, int mensilità)
        {
            Console.WriteLine("Con l'iscrizione " + iscrizione + " la mensilità sarà " + mensilità + "€");
        }

        public int SetMonthlyPayment()
        {
            if (Iscrizione.ToLower() == "annuale")
            {
                return 20;
            }
            else
            {
                return 40;
            }
        }
    }

    class Dipendente 
    {
        public string Nome;
        public string Cognome;
        public int Age;
        public string Contratto;
        public string Lavoro;

        public Dipendente(string name, string surName, int age, string contratto, string lavoro)
        {
            this.Nome = name;
            this.Cognome = surName;
            this.Age = age;
            this.Contratto = contratto;
            this.Lavoro = lavoro;
        }

        public int getHourlyWage()
        {
            if(Lavoro == "operaio"){
                return 9;
            }else{
                return 10;
            }
        }
    }

    class Animale 
    {
        public string Razza;
        public string Name;
        public int Eta;
        public int Peso;    
        public string Proprietario;

        public Animale(string razza, string name, int eta, int peso, string propr)
        {
            this.Razza = razza;
            this.Name = name;
            this.Eta = eta;
            this.Peso = peso;
            this.Proprietario = propr; 
        } 
    }

    




}
