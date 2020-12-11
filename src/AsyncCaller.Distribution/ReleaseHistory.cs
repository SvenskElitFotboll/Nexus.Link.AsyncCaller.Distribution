﻿using System.Collections.Generic;
using Nexus.Link.Libraries.Core.Platform.ServiceMetas;

namespace AsyncCaller.Distribution
{
    public class ReleaseHistory
    {
        public static List<Release> Releases { get; } = new List<Release>
        {
            new Release("1.1.0")
            {
                Notes = new List<Note>
                {
                    Note.Feature("Support for multiple tenants")
                }
            },
            new Release("1.0.1")
            {
                Notes = new List<Note>
                {
                    Note.Feature("Log distribution invocations")
                }
            },
            new Release("1.0.0")
            {
                Notes = new List<Note>
                {
                    Note.Feature("Initial release")
                }
            }
        };
    }
}
