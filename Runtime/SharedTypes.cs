using RPGFramework.Core.SharedTypes;

namespace RPGFramework.DebugRoom.SharedTypes
{
    /// <summary>
    /// The debug room, as Core resolves it: pages that jump to any field, set any variable, start any battle and try the
    /// game's audio, reporting a jump or a battle for the game's module router to carry out.
    /// </summary>
    public interface IDebugRoomModule : IModule
    {
    }
}
