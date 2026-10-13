namespace Core;

public class DipartmentPosition
{
    public Guid IdDepartament { get; }
    public Guid IdPosition { get; }

    public DipartmentPosition(Guid iddepartment, Guid idposition)
    {
        IdDepartament = iddepartment;
        IdPosition = idposition;
    }
}
