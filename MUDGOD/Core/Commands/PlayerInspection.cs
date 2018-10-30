using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Discord;
using Discord.Addons.Interactive;
using Discord.Commands;
using Discord.WebSocket;


namespace MUDGOD.Core.Commands {
    public class PlayerInspection : InteractiveBase {

        //Display the players name, race, and level
        [Group("inspect"), Alias("Inspect","peek","Peek"),Summary("Please work already")]
        public class PlayerInspectionGroup : InteractiveBase {


            [Command(""), Alias("Player", "player", "user", "User"), Summary("Display a players Char Name, Race, Class and Level")]
            public async Task InspectPlayer(IUser targetUser = null) {
                ulong id = Context.User.Id;
                var mention = Context.User.Mention;

                //Check they aren't already registered
                if (!Data.SaveLoad.CheckPlayerIsRegistered(id)) {
                    await Context.Channel.SendMessageAsync($"{mention}\nYou need to register a Character first] **^register**");
                    return;
                }

                ulong targetId;
                string targetMention;


                
                //Get their character
                if (targetUser != null) {
                    targetId = targetUser.Id;
                    targetMention = targetUser.Mention;
                }
                else {
                    targetId = id;
                    targetMention = mention;
                }

                //Make sure there is a character
                if (!Data.SaveLoad.CheckPlayerIsRegistered(targetId)) {
                    await Context.Channel.SendMessageAsync($"{mention}\n{targetMention} has not registered a character");
                    return;
                }

                PlayerCharacter theInspected = Data.SaveLoad.LoadPlayerCharacter(targetId);

                //Display Relevant info
                await ReplyAsync($"{mention}\nThis is {targetMention}'s Character\n" +
                                $"Name:  {theInspected.name}\n" +
                                $"Race:  {theInspected.myRace.name}\n" +
                                $"Class: {theInspected.myClass.name}\n" +
                                $"Level: {theInspected.level}");
               

            }

            [Command("Stats"), Alias("stats", "statistics", "Statistics", "stat", "Stat"), Summary("Display a users stats")]
            public async Task InspectStats(IUser targetUser = null) {
                ulong id = Context.User.Id;
                var mention = Context.User.Mention;

                //Check they aren't already registered
                if (!Data.SaveLoad.CheckPlayerIsRegistered(id)) {
                    await Context.Channel.SendMessageAsync($"{mention}\nYou need to register a Character first] **^register**");
                    return;
                }

                ulong targetId;
                string targetMention;

                //Get their character
                if (targetUser != null) {
                    targetId = targetUser.Id;
                    targetMention = targetUser.Mention;
                }
                else {
                    targetId = id;
                    targetMention = mention;
                }

                //Make sure there is a character
                if (!Data.SaveLoad.CheckPlayerIsRegistered(targetId)) {
                    await Context.Channel.SendMessageAsync($"{mention}\n{targetMention} has not registered a character");
                    return;
                }

                PlayerCharacter theInspected = Data.SaveLoad.LoadPlayerCharacter(targetId);

                //Display Relevant info
                await ReplyAsync($"{mention}\nThis is {targetMention}'s Character\n" +
                                $"Name:  {theInspected.name}\n" +
                                $"Strength:     {theInspected.Strength()}  [{theInspected.strPoints} * {theInspected.myClass.strMulti}]\n" +
                                $"Dexterity:    {theInspected.Dexterity()}  [{theInspected.dexPoints} * {theInspected.myClass.dexMulti}]\n" +
                                $"Intelligence: {theInspected.Intelligence()}  [{theInspected.intPoints} * {theInspected.myClass.intMulti}]\n" +
                                $"Wisdom:       {theInspected.Wisdom()}  [{theInspected.intPoints} * {theInspected.myClass.wisMulti}]\n" +
                                $"Luck:         {theInspected.Wisdom()}  [{theInspected.intPoints} * {theInspected.myClass.wisMulti}]\n" +
                                $"Defense:      {theInspected.Defense()}  [{theInspected.intPoints} * {theInspected.myClass.defMulti}]");
            }

            [Command("Statpoints"),Alias("StatPoints","statpoints","statPoints"), Summary("Display a users stat points")]
            public async Task InspectStatPoints(IUser targetUser = null) {

            }




        }
    }
}
