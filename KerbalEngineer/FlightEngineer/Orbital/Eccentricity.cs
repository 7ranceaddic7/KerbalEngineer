﻿// Name:    Kerbal Engineer Redux
// Author:  CYBUTEK
// License: Attribution-NonCommercial-ShareAlike 3.0 Unported

using KerbalEngineer.Extensions;
using UnityEngine;

namespace KerbalEngineer.FlightEngineer.Orbital
{
    public class Eccentricity : Readout
    {
        protected override void Initialise()
        {
            Name = "Eccentricity";
            Description = "Shows your current eccentricity.";
            Category = ReadoutCategory.Orbital;
        }

        public override void Draw()
        {
            DrawLine(FlightGlobals.ActiveVessel.orbit.eccentricity.ToAngle());
        }
    }
}
