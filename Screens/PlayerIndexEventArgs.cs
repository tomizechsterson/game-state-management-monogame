using System;
using Microsoft.Xna.Framework;

namespace MgGSM.Screens
{
    // Custom event argument which includes the index of the player who
    // triggered the event. This is used by the MenuEntry.Selected event.
    public class PlayerIndexEventArgs : EventArgs
    {
        private readonly PlayerIndex _playerIndex;

        public PlayerIndex PlayerIndex => _playerIndex;

        public PlayerIndexEventArgs(PlayerIndex playerIndex)
        {
            _playerIndex = playerIndex;
        }
    }
}