using System;
using MgGSM.StateManagement;

namespace MgGSM
{
    // Our game's implementation of IScreenFactory which can handle creating the screens
    // when resuming from being tombstoned.
    public class ScreenFactory : IScreenFactory
    {
        public GameScreen CreateScreen(Type screenType)
        {
            return Activator.CreateInstance(screenType) as GameScreen;
        }
    }
}