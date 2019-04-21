namespace BuilderAndPrototype.Prototype
{
    public interface IPrototype
    {
        IPrototype ShallowClone();
        IPrototype DeepClone();
    }
}

