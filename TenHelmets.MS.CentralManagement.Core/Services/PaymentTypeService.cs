namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PaymentTypeService : BaseService<PaymentType>, IPaymentTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentTypeRepository"></param>
        public PaymentTypeService(IPaymentTypeRepository paymentTypeRepository)
            : base(paymentTypeRepository)
        {

        }
    }
}
