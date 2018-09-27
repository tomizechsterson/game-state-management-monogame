using System;
using MgGSM.StateManagement;

namespace MgGSM
{
    public class ScreenFactory : IScreenFactory
    {
        public GameScreen CreateScreen(Type screenType)
        {
            return Activator.CreateInstance(screenType) as GameScreen;
        }
    }
}