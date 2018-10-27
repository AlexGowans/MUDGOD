using System.Linq;
using System.Threading.Tasks;

using MUDGOD.Resources.Database;


namespace MUDGOD.Core.SaveLoad {
    public static class SaveLoad {

        public static PlayerCharacter GetPlayerCharacter(ulong userId) {
            using (var dbContext = new SqliteDbContext()) {
                //Check that the user id exists
                if (dbContext.playerList.Where(x => x.playerId == userId).Count() < 1) return null;
                //Otherwise load and return the PlayerCharacter
                return dbContext.playerList.Where(x => x.playerId == userId).FirstOrDefault();
                
            }
        }

        public static async void SavePlayerCharacter(ulong userID, PlayerCharacter newPC) {
            using (var dbContex = new SqliteDbContext()) {
                //If there are no entries in the database with this user id then make one
                if (dbContex.playerList.Where(x => x.playerId == userID).Count() < 1) {
                    dbContex.playerList.Add(newPC);
                }
                //Otherwise update the existing entry
                else {
                    //PlayerCharacter oldPC = dbContex.playerList.Where(x => x.playerId == userID).FirstOrDefault();  //get the first entry with matching ID
                    dbContex.playerList.Update(newPC);
                }
                await dbContex.SaveChangesAsync();
            }
        }
    }
}
