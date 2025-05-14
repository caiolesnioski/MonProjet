namespace Banque.Entities

    public class Oparations
    {
       
        public string Type { get; set; }

        public decimal Montant { get; set; }

        public DateTime Date { get; set; }
       
        public Oparations(string type, decimal montant = 0)
        {
            Type = type;
            Montant = montant;
            Date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {Type} : {Montant}";
        }
        
    }