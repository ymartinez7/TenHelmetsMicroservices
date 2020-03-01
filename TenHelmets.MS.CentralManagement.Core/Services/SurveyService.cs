namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class SurveyService : BaseService<Survey>, ISurveyService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="surveyRepository"></param>
        public SurveyService(ISurveyRepository surveyRepository)
            : base(surveyRepository)
        {

        }
    }
}
