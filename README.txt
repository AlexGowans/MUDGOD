Welcome to MUDGOD

*Need to read a players stats? Data.SaveLoad.GetPlayerCharacter(userId); returns a PlayerCharacter

*If you add stats to the PlayerCharacter class remember to update the database
I believe all you have to do is open the "Package Manager Console" in VS then enter "update-database"

program.cs : initialise the bot and wait for commands


/GameEngine
	/Actors/
		Actor.cs 			: default class for living beings
		PlayerCharacter.cs	: an actor for player characters
							  includes id, playerName and player Class
				
	/PlayerClasses/
		PlayerClass.cs 		: default template for player classes
		
	/GameCommands			: All classes containing game related commands
					: Take note of the use of : Interactive instead of ModuleCommand, its an adon w/more features