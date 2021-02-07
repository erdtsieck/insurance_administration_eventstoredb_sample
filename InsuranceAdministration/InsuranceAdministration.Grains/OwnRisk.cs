using InsuranceAdministration.GrainInterfaces;

namespace InsuranceAdministration.Grains
{
    internal class OwnRisk : IOwnRisk
    {
        public decimal Voluntary { get; set; }
        public decimal Mandatory { get; set; }
    }
}