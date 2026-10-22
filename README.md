# RPGFramework.DebugRoom.SharedTypes

What a game's module router needs to route the debug room, without depending on the Debug Room package itself.

Requires Unity 6000.6 or newer and RPGFramework.Core.SharedTypes. **Compiled only where `ENABLE_RPG_FRAMEWORK_DEBUG` is
defined**: its assembly carries the define as a constraint, so in a build profile without it there is nothing to
reference, and Unity drops the references to it. Anything of yours that names these types sits inside
`#if ENABLE_RPG_FRAMEWORK_DEBUG`.

- **`IDebugRoomModule`**: the debug room, as Core resolves it.
- **`DebugRoomConstants.MODULE_ID`**: its module id, 255, the top of the range, clear of your own modules.
- **`DebugRoomOutcomes`**: what the room reports as it leaves, for the game's module router to route —
  - `CLOSED`: backed out of; the title follows.
  - `FIELD`: a jump; the field and spawn point are in the `IFieldArgsStore`.
  - `BATTLE`: a battle; its arena and flags are in the `IBattleArgsStore`.

The default module router routes all three, and the title's `DebugMenuOutcomes.DEBUG_ROOM`, in the Menu shared types.
