using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars_Project.ViewModel
{
    public class NavigationMenu
    {
        public CharacterSheetVM CharacterSheetVM_O { get; set; }
        public MapVM MapVM_O { get; set; }
        public SettingsVM SettingsVM_O { get; set; }
        public MusicVM MusicVM_O { get; set; }
        public MonstersVM MonstersVM_O { get; set; }
        public NavigationMenu()
        {
            CharacterSheetVM_O = new CharacterSheetVM();
            MapVM_O = new MapVM();
            SettingsVM_O = new SettingsVM();
            MusicVM_O = new MusicVM();
            MonstersVM_O = new MonstersVM();
        }
    }
}
