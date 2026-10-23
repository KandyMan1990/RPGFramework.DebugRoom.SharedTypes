namespace RPGFramework.DebugRoom.SharedTypes.Constants
{
    /// <summary>What the debug room tells Core happened, for the game's module router to route.</summary>
    public static class DebugRoomOutcomes
    {
        /// <summary>Backed out of: the game goes back to its title.</summary>
        public const byte CLOSED = 1;

        /// <summary>A jump: the field and spawn point are in the <c>IFieldArgsStore</c>, the playthrough begun.</summary>
        public const byte FIELD = 2;

        /// <summary>A battle: its arena and flags are in the <c>IBattleArgsStore</c>.</summary>
        public const byte BATTLE = 3;

        /// <summary>
        /// A scenario was loaded to go to where it was saved: the game goes to the module it was saved in, its
        /// arguments the scenario's.
        /// </summary>
        public const byte SCENARIO = 4;
    }
}
