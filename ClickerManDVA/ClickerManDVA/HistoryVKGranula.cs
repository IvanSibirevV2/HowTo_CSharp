using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public class HistoryVKGranula
    {
        public System.DateTime p_DTN = System.DateTime.Now;
        public Action Act = () => { };
        public VK p_VK= null;
        public HistoryVKGranula() { }
        public HistoryVKGranula(Action _Act) { this.Act = _Act; }
        public HistoryVKGranula(Action _Act, VK _VK) { this.Act = _Act; this.p_VK = _VK; }
    }
}