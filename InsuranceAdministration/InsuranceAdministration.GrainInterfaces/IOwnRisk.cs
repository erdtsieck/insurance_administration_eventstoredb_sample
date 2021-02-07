namespace InsuranceAdministration.GrainInterfaces
{
    public interface IOwnRisk
    {
        decimal Voluntary { get; }
        decimal Mandatory { get; }
    }
}