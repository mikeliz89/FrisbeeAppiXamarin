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
            _database.CreateTableAsync<Track>().Wait();
        }

        #region Game

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

        #endregion

        #region Track

        public Task<List<Track>> GetTracksAsync()
        {
            return _database.Table<Track>().ToListAsync();
        }

        public Task<Track> GetTrackAsync(int id)
        {
            return _database.Table<Track>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveTrackAsync(Track Track)
        {
            if (Track.ID != 0)
            {
                return _database.UpdateAsync(Track);
            }
            else
            {
                return _database.InsertAsync(Track);
            }
        }

        public Task<int> DeleteTrackAsync(Track Track)
        {
            return _database.DeleteAsync(Track);
        }

        #endregion

    }
}
