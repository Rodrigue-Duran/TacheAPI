using TacheAPI.Models;

namespace TacheAPI.Services
{
    public interface ITacheService
    {
         Task<Tache?> CreateTacheAsync(Tache tache);
         Task<bool> DeleteTacheAsync(int id);
         Task<bool> UpdateTacheAsync(int id , Tache tache);
         Task<Tache?> GetTacheByIdAsync(int id);
         Task<List<Tache>> GetAllTachesAsync();
         Task<bool> MakeFinishAsync(int id);
        
    }
}
