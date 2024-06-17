using ClaimTheSquareFullStack.Model;

namespace ClaimTheSquareFullStackWithDI.DependencyInjection
{
    public class InMemoryTextObjectRepository : ITextObjectRespository
    {
        private readonly List<TextObject> _textObjects;

        public InMemoryTextObjectRepository()
        {
            _textObjects = new List<TextObject>();
        }
        public Task<IEnumerable<TextObject>> ReadAll()
        {
            return Task.FromResult(_textObjects);
        }

        public bool Create(TextObject textObject)
        {
            _textObjects.Add(textObject);
            return true;
        }
    }
}
