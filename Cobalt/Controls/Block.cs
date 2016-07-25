﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;

namespace Cobalt.Controls
{
    public class Block : IBlock
    {       
        public MessageLine Source { get; set; }
        public string TimeString { get; set; }
        public string NickString { get; set; }
        public int CharStart { get; set; }
        public int CharEnd { get; set; }
        public double Y { get; set; }
        public double NickX { get; set; }
        public double TextX { get; set; }
        public double Height { get; set; }
        public double TimeWidth { get; set; }
        public double NickWidth { get; set; }
        public int NumLines { get; set; }     
    }
}