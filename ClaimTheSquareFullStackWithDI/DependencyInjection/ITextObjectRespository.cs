using ClaimTheSquareFullStack.Model;

namespace ClaimTheSquareFullStackWithDI.DependencyInjection
{
    interface ITextObjectRespository
    {
        IEnumerable<TextObject> ReadAll();
        bool Create(TextObject textObject);
    }
}
