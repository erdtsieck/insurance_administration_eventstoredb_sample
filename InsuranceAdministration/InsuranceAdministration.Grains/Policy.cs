using System;
using System.Collections.Generic;
using InsuranceAdministration.GrainInterfaces;

namespace InsuranceAdministration.Grains
{
    internal class Policy : IPolicy
    {
        public bool Active { get; set; }
        public string PolicyHolder { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ICoverage> Coverages { get; set; } = new List<ICoverage>();
        public List<ICoverage> RetroActiveCoverages { get; set; } = new List<ICoverage>();
    }
}
