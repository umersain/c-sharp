﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubnubApi
{
    public class PNFileEventResult
    {
        public string Channel { get; set; }
        public string Subscription { get; set; }
        public string Publisher { get; set; }
        public long Timetoken { get; set; }
        public object Message { get; set; }
        public string FileId { get; set; }
        public string FileName { get; set; }

    }
}