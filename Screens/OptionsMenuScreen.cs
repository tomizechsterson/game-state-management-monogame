namespace MgGSM.Screens
{
    // The options screen is brought up over the top of the main menu
    // screen, and gives the user a chance to configure the game
    // in various hopefully useful ways.
    public class OptionsMenuScreen : MenuScreen
    {
        private enum Ungulate
        {
            BactrianCamel,
            Dromedary,
            Llama,
        }

        private readonly MenuEntry _ungulateMenuEntry;
        private readonly MenuEntry _languageMenuEntry;
        private readonly MenuEntry _frobnicateMenuEntry;
        private readonly MenuEntry _elfMenuEntry;

        private static Ungulate _currentUngulate = Ungulate.Dromedary;
        private static readonly string[] Languages = { "C#", "French", "Deoxyribonucleic acid" };
        private static int _currentLanguage;
        private static bool _frobnicate = true;
        private static int _elf = 23;

        public OptionsMenuScreen() : base("Options")
        {
            _ungulateMenuEntry = new MenuEntry(string.Empty);
            _languageMenuEntry = new MenuEntry(string.Empty);
            _frobnicateMenuEntry = new MenuEntry(string.Empty);
            _elfMenuEntry = new MenuEntry(string.Empty);

            SetMenuEntryText();

            var back = new MenuEntry("Back");

            _ungulateMenuEntry.Selected += UngulateMenuEntrySelected;
            _languageMenuEntry.Selected += LanguageMenuEntrySelected;
            _frobnicateMenuEntry.Selected += FrobnicateMenuEntrySelected;
            _elfMenuEntry.Selected += ElfMenuEntrySelected;
            back.Selected += OnCancel;

            MenuEntries.Add(_ungulateMenuEntry);
            MenuEntries.Add(_languageMenuEntry);
            MenuEntries.Add(_frobnicateMenuEntry);
            MenuEntries.Add(_elfMenuEntry);
            MenuEntries.Add(back);
        }

        // Fills in the latest values for the options screen menu text.
        private void SetMenuEntryText()
        {
            _ungulateMenuEntry.Text = $"Preferred ungulate: {_currentUngulate}";
            _languageMenuEntry.Text = $"Language: {Languages[_currentLanguage]}";
            _frobnicateMenuEntry.Text = $"Frobnicate: {(_frobnicate ? "on" : "off")}";
            _elfMenuEntry.Text = $"elf: {_elf.ToString()}";
        }

        private void UngulateMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            _currentUngulate++;

            if (_currentUngulate > Ungulate.Llama)
                _currentUngulate = 0;

            SetMenuEntryText();
        }

        private void LanguageMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            _currentLanguage = (_currentLanguage + 1) % Languages.Length;
            SetMenuEntryText();
        }

        private void FrobnicateMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            _frobnicate = !_frobnicate;
            SetMenuEntryText();
        }

        private void ElfMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            _elf++;
            SetMenuEntryText();
        }
    }
}