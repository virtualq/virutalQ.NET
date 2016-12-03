﻿using VirtualQNet.Caller;
using VirtualQNet.LineGroups;
using VirtualQNet.Lines;

namespace VirtualQNet
{
    public interface IVirtualQ
    {
        ILinesHandler Lines { get; }
        ILineGroupsHandler LineGroups { get; }
        ICallerHandler Callers { get; }
    }
}