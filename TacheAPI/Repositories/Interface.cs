using TacheAPI.Models;

namespace TacheAPI.Repositories
{
    public interface ITacheRepository
    {
        Task<Tache> CreateTacheAsync(Tache tache);
        Task<bool> DeleteTacheAsync(int id);
        Task<bool> UpdateTacheAsync(int id , Tache tache);
        Task<Tache?> GetTacheByIdAsync(int id);
        Task<List<Tache>> GetAllTachesAsync();
        Task<bool> MakeFinishAsync(int id);

        // Pour la prochaine version, on peut ajouter des méthodes de recherche pour les taches:
        //Task<List<Tache>> GetTachesByStatutAsync(Statut statut);
        // Task<List<Tache>> GetTachesByDateDeCreationAsync(DateTime dateDeCreation);
        // Task<List<Tache>> GetTachesByDateDeFinAsync(DateTime dateDeFin);
        // Task<List<Tache>> GetTachesByTitreAsync(string titre);
        // Task<List<Tache>> GetTachesByDescriptionAsync(string description);
    }
}
