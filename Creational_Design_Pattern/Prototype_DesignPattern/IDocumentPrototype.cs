
namespace Prototype_DesignPattern
{

    public interface IDocumentPrototype<T>
    {
        T Clone();
    }
}