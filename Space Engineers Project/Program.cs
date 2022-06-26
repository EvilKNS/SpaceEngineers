using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using VRageMath;
using VRage.Game;
using VRage.Collections;
using Sandbox.ModAPI.Ingame;
using VRage.Game.Components;
using VRage.Game.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using Sandbox.Game.EntityComponents;
using SpaceEngineers.Game.ModAPI.Ingame;
using VRage.Game.ObjectBuilders.Definitions;

namespace Space_Engineers_Project
{
    public sealed class Program : MyGridProgram
    {
        // =================================================================================== Kodo PRADŽIA ===================================================================================//

        public Program()
        {
            // Konstruktorius iškviečiamas tik vieną karta prieš programos paleidimą, ar naudojamą bet koki kitą metodą. Naudojamas kuriant scenarijus.
        }

        public void Main(string args)
        {
            // Pagrindinio scenarijaus iškvietimas kekvieną kartą, iš PROGRAMUOJAMO BLOKO VYKDYMO veiksmų. Metodas reikalingas, o argumentą galima pašalinti, jei jis nereikalingas, ar nebūtinas.
        }

        public void Save()
        {
            // Iškvietimas būsenai išsaugoti. Išsaugo Storage field. Galimi ir kiti išsaugojimo būdai.Neprivalomas metodas, jei nereikia galima ir pašalinti.
        }
    }
}

        // =================================================================================== Kodo PABAIGA =================================================================================== //