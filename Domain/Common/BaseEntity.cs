namespace Domain.Common;

public abstract class BaseEntity<TId> where TId : notnull
{
    public TId Id { get; protected set; }

    protected BaseEntity(TId id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        if(obj is not BaseEntity<TId> other) return false;
        return Id.Equals(other.Id);
    }

    public override int GetHashCode() => Id.GetHashCode();

    public static bool operator ==(BaseEntity<TId>? left, BaseEntity<TId>? right)
    {
        return Equals(left, right);
    }
    
    public static bool operator !=(BaseEntity<TId>? left, BaseEntity<TId>? right)
    {
        return !Equals(left, right);
    }

}