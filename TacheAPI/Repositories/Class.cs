using Microsoft.EntityFrameworkCore;
using TacheAPI.Data;
using TacheAPI.Models;

namespace TacheAPI.Repositories
{
    public class TacheRepository : ITacheRepository
    {
        private readonly AppDbContext _context;
        public TacheRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Tache> CreateTacheAsync(Tache tache)
        {
            _context.Taches.Add(tache);
            await _context.SaveChangesAsync();
            return tache;
        }

        public async Task<bool> DeleteTacheAsync(int id)
        {
            Tache? tache = _context.Taches.Find(id);
            if (tache != null) {
                _context.Taches.Remove(tache);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Tache>> GetAllTachesAsync()
        {
            return await _context.Taches.ToListAsync();
        }

        public async Task<Tache?> GetTacheByIdAsync(int id)
        {
            return await _context.Taches.FindAsync(id);
        }

        public async Task<bool> MakeFinishAsync(int id)
        {
            Tache? tache = await _context.Taches.FindAsync(id);
            if (tache != null)
            {
                tache.Statut = Statut.Terminee;
                tache.DateDeFin = DateTime.Now;
                _context.Taches.Update(tache); 
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }


        public async  Task<bool> UpdateTacheAsync(int id, Tache tache)
        {
            Tache? existingTache = _context.Taches.Find(id);
            if (existingTache != null)
            {
                existingTache.Titre = tache.Titre;
                existingTache.Description = tache.Description;
                existingTache.Statut = tache.Statut;
                existingTache.DateDeFin = tache.DateDeFin;
                _context.Taches.Update(existingTache);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
