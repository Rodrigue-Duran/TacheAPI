using TacheAPI.Models;
using TacheAPI.Repositories;

namespace TacheAPI.Services
{
    public class TacheService : ITacheService
    {
        private readonly ITacheRepository _tacheRepository;
        public TacheService(ITacheRepository tacheRepository)
        {
            _tacheRepository = tacheRepository;
        }

        public async Task<Tache?> CreateTacheAsync(Tache tache)
        {
            if (!IsValidTacheForCreation(tache))
                return null;

            return await _tacheRepository.CreateTacheAsync(tache);
        }

        public async Task<bool> DeleteTacheAsync(int id)
        {
            return await _tacheRepository.DeleteTacheAsync(id);
        }

        public Task<List<Tache>> GetAllTachesAsync()
        {
            return _tacheRepository.GetAllTachesAsync();
        }

        public Task<Tache?> GetTacheByIdAsync(int id)
        {
           return _tacheRepository.GetTacheByIdAsync(id);
        }

        public Task<bool> MakeFinishAsync(int id)
        {
            return _tacheRepository.MakeFinishAsync(id);
        }

        public async Task<bool> UpdateTacheAsync(int id, Tache tache)
        {
           if (!IsValidTacheForUpdate(tache)) return false;
            return await _tacheRepository.UpdateTacheAsync(id, tache);
        }

        private static bool IsValidTacheForCreation(Tache tache)
        {
            // Appliquons les règles de structure d'une tache à sa création
            if (tache == null) return false;
            if (string.IsNullOrEmpty(tache.Titre)) return false;
            if(string.IsNullOrEmpty(tache.Description))  return false;
            if (tache.DateDeFin != null) return false;
            if(tache.Statut!= Statut.Creee) return false;
            return true;
        }   

        private static bool IsValidTacheForUpdate(Tache tache)
        {
            // Appliquer les règles de structure d'une tache à sa mise à jour
            if (tache == null) return false;
            if (string.IsNullOrEmpty(tache.Titre)) return false;
            if(string.IsNullOrEmpty(tache.Description))  return false;
            if (tache.DateDeFin != null && tache.DateDeFin < tache.DateDeCreation) return false;
            return true;
        }


    }
}
