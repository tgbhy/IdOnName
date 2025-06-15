﻿# IdOnName
## Explanation
This plugin was requested by Souin (yuifsss) on the EXILED's Discord Server on 13/06/2025.

He asked :
> Name: Id Shower
> 
> Desc : Id will be written at the beginning of the player's name.

## Installation
- Download the latest `IdOnName.dll` in [releases](https://github.com/tgbhy/IdOnName/releases)
- Put the .dll file in your EXILED's plugins folder. (Mostly on `.config/EXILED/Plugins/`)
- Restart your server.
- Enjoy!

## Configuration
| Parameter | Type | Description |
| --- | --- | --- |
| IsEnabled | boolean (true/false) | Should players be renamed with their ids ? | 
| Debug | boolean (true/false) | No debug added in this plugin, you can leave it disabled. |
| Format | string | The format to use for player names. Use {PlayerId} for the player's ID and {PlayerName} for the player's name. Example: "{PlayerId} - {PlayerName}". |
| FormatOnRoleChange | boolean (true/false) | Should the names be formatted on roles change ? (Especially if you use a custom role system, this will ensure that the names are updated when a player changes roles using the custom name.) |