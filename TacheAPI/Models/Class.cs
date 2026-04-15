namespace TacheAPI.Models
{
    public enum Statut
    {
        Creee,
        Terminee,
    }
    public class Tache
    {
        // id, titre, dateDeCreation, dateDeFin, description, statut
        public int Id { get; set; }

        public string Titre { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Statut Statut { get; set; } = Statut.Creee;

        public DateTime DateDeCreation { get; set;} = DateTime.Now;

        public DateTime? DateDeFin { get; set; }
    }
}
