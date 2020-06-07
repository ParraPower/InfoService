using InfoServiceDataLayer.SqlHelper.Implementations;
using Microsoft.Extensions.Options;

namespace InfoServiceDataLayer.Repositories.Implementations
{
    public class BaseRepository
    {
        public BaseRepository(IOptions<DatabaseSettings> options)
        {
            _databaseSettings = options.Value;
        }

        //private readonly ILogger _logger { get; set; }

        protected DatabaseSettings _databaseSettings { get; set; }
    }
}
