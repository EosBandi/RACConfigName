using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MissionPlanner.Controls.PreFlight;
using MissionPlanner.Controls;
using System.Linq;

namespace MissionPlanner.RACConfigName
{
    public class RACConfigNamePlugin : MissionPlanner.Plugin.Plugin
    {
        public override string Name
        {
            get { return "RACConfigName"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Andras Schaffer"; }
        }

        //[DebuggerHidden]
        public override bool Init()
        {
            loopratehz = 1;  //Every 

            return true;
        }

        public override bool Loaded()
        {
            return true;
        }

        public override bool Loop()
        {

            return true;
        }

        public override bool Exit()
        {
            return true;
        }
    }
}