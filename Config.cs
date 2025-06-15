using Exiled.API.Interfaces;
using System.ComponentModel;

namespace IdOnName
{
    public class Config : IConfig
    {
        [Description("Should players be renamed with their ids ?")]
        public bool IsEnabled { get; set; } = true;
        [Description("No debug added in this plugin, you can leave it disabled.")]
        public bool Debug { get; set; } = false;
        [Description("The format to use for player names. Use {PlayerId} for the player's ID and {PlayerName} for the player's name. Example: \"{PlayerId} - {PlayerName}\".")]
        public string Format { get; set; } = "{PlayerId} - {PlayerName}";
        [Description("Should the names be formatted on roles change ? (Especially if you use a custom role system, this will ensure that the names are updated when a player changes roles using the custom name.)")]
        public bool FormatOnRoleChange { get; set; } = false;
    }
}
