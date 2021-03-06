﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerbal_Construction_Time
{
    public static class KCT_GameStates
    {
        public static double UT;
        public static KCTVessel activeVessel = null;
        public static int activeVesselIndex;
        public static List<KCTVessel> vesselList = new List<KCTVessel>();
        public static int totalCost;
        public static bool canWarp = false, warpRateReached = false;
        public static bool showMainGUI = false, showEditorGUI = false, showSOIAlert = false;
        public static string lastSOIVessel = "";
        public static Dictionary<string, string> vesselDict = new Dictionary<string, string>();
        public static List<VesselType> VesselTypesForSOI = new List<VesselType>() { VesselType.Base, VesselType.Lander, VesselType.Probe, VesselType.Ship, VesselType.Station };
        public static List<Orbit.PatchTransitionType> SOITransitions = new List<Orbit.PatchTransitionType> { Orbit.PatchTransitionType.ENCOUNTER, Orbit.PatchTransitionType.ESCAPE };
        //public static GameScenes currentScene;

    }

}

/*Copyright (c) 2013, Zachary Eck (a.k.a. Ekku Zakku) All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

Kerbal Space Program is Copyright (C) 2013 Squad. See http://kerbalspaceprogram.com/. This project is in no way associated with nor endorsed by Squad.
*/