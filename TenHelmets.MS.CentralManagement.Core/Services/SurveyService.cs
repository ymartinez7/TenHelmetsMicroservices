using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public class SurveyService : BaseService<Survey>, ISurveyService
    {
        public SurveyService(ISurveyRepository surveyRepository)
            : base(surveyRepository)
        {

        }
    }
}
