using System.Linq;
using System.Threading.Tasks;

using MUDGOD.Resources.Database;


namespace MUDGOD.Data{
    public static class SaveLoad {

        public static PlayerCharacter LoadPlayerCharacter(ulong userId) {
            using (var dbContext = new SqliteDbContext()) {
                //Check that the user id exists
                if (dbContext.playerListDB.Where(x => x.playerId == userId).Count() < 1) return null;
                //Otherwise load and return the PlayerCharacter
                PlayerData data = dbContext.playerListDB.Where(x => x.playerId == userId).FirstOrDefault();
                PlayerCharacter pc = ConvertDataToPlayer(data);
                return pc;                
            }
        }

        public static async Task SavePlayerCharacter(ulong userID, PlayerCharacter pc) {
            using (var dbContex = new SqliteDbContext()) {
                //If there are no entries in the database with this user id then make one
                if (dbContex.playerListDB.Where(x => x.playerId == userID).Count() < 1) {
                    dbContex.playerListDB.Add(ConvertPlayerToData(pc));
                }
                //Otherwise update the existing entry
                else {
                    //PlayerCharacter oldPC = dbContex.playerList.Where(x => x.playerId == userID).FirstOrDefault();  //get the first entry with matching ID
                    
                    dbContex.playerListDB.Update(ConvertPlayerToData(pc));
                }
                await dbContex.SaveChangesAsync();
            }
        }

        public static bool CheckPlayerIsRegistered(ulong userId) {
            using (var dbContext = new SqliteDbContext()) {
                //Check that the user id exists
                if (dbContext.playerListDB.Where(x => x.playerId == userId).Count() < 1) return false;
                //It does, return true
                return true;
            }
        }


        public static PlayerData ConvertPlayerToData(PlayerCharacter pc) {
            PlayerData theData = new PlayerData(id: pc.playerId, plrNme: pc.playerName,
                                                nme: pc.name, clss: pc.myClass.id, race: pc.myRace.id,
                                                peasant: pc.peasantLevel, fighter: pc.fighterLevel,
                                                magician: pc.magicianLevel, ranger: pc.rangerLevel,
                                                size: pc.bodySize, lev: pc.level,
                                                hpm: pc.healthPointsMax, hp: pc.healthPoints,
                                                mpm: pc.manaPointsMax, mp: pc.manaPoints,
                                                str: pc.strPoints, dex: pc.dexPoints, intP: pc.intPoints,
                                                wis: pc.wisPoints, lck: pc.lckPoints, def: pc.defPoints,
                                                acc: pc.accuracyPoints, dodge: pc.passiveDodgePoints,
                                                crncy: pc.currency,
                                                locX: pc.locationX, locY: pc.locationY);
            return theData;
        }
        public static PlayerCharacter ConvertDataToPlayer(PlayerData theData) {
            PlayerCharacter pc = new PlayerCharacter(id: theData.playerId, plrNme: theData.playerName, nme: theData.name,
                                        clss: PlayerClassFunctions.GetClass(theData.myClassIdHolder), race: PlayerRaceFunctions.GetRace(theData.myRaceIdHolder),
                                        peasant: theData.peasantLevel, fighter: theData.fighterLevel,
                                        magician: theData.magicianLevel, ranger: theData.rangerLevel,
                                        size: theData.bodySize, lev: theData.level,
                                        hpm: theData.healthPointsMax, hp: theData.healthPoints,
                                        mpm: theData.manaPointsMax, mp: theData.manaPoints,
                                        str: theData.strPoints, dex: theData.dexPoints, intP: theData.intPoints,
                                        wis: theData.wisPoints, lck: theData.lckPoints, def: theData.defPoints,
                                        acc: theData.accuracyPoints, dodge: theData.passiveDodgePoints,
                                        crncy: theData.currency,
                                        locX: theData.locationX, locY: theData.locationY);
            return pc;
        }
    }
}
