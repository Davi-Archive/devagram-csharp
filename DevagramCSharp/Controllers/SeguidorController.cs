using DevagramCSharp.Repository;

namespace DevagramCSharp.Controllers
{
    public class SeguidorController
    {
        private readonly ILogger<SeguidorController> _logger;
        private readonly ISeguidorRepository _seguidorRepository;

        public SeguidorController(ILogger<SeguidorController> logger, ISeguidorRepository seguidorRepository)
        {
            _logger = logger;
            _seguidorRepository = seguidorRepository;
        }
    }
}
