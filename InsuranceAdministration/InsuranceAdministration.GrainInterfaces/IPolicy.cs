using System;
using System.Collections.Generic;

namespace InsuranceAdministration.GrainInterfaces
{
    public interface IPolicy
    {
        bool Active { get; }
        string PolicyHolder { get; }
        List<ICoverage> Coverages { get; }
        List<ICoverage> RetroActiveCoverages { get; }

    }
}
