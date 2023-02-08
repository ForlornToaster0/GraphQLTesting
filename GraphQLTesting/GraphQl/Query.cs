using GraphQLTesting.Models;

namespace GraphQLTesting.GraphQl
{
    public class Query
    {
        public Task<List<Book>> GetBooks([Service] Repository.Repository repository) =>
             repository.GetBooksAsync();
    }
}
