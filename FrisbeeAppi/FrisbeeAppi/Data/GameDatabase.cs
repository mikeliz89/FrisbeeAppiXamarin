using FrisbeeAppi.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrisbeeAppi.Data
{
    public class GameDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public GameDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Game>().Wait();
        }

        public Task<List<Game>> GetGamesAsync()
        {
            return _database.Table<Game>().ToListAsync();
        }

        public Task<Game> GetGameAsync(int id)
        {
            return _database.Table<Game>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveGameAsync(Game Game)
        {
            if (Game.ID != 0)
            {
                return _database.UpdateAsync(Game);
            }
            else
            {
                return _database.InsertAsync(Game);
            }
        }

        public Task<int> DeleteGameAsync(Game Game)
        {
            return _database.DeleteAsync(Game);
        }
    }
}
