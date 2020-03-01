namespace TenHelmets.MS.Infrastructure.Data.Factories
{
    using TenHelmets.MS.Infrastructure.Data.Enums;
    using TenHelmets.MS.Infrastructure.Data.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public static class ServiceConnectionFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceTypeConnection"></param>
        /// <returns></returns>
        public static IServiceConnection GetServiceConnection(ServiceTypeConnection serviceTypeConnection)
        {
            IServiceConnection _serviceConnection = null;
            switch (serviceTypeConnection)
            {
                case ServiceTypeConnection.Soap:
                    break;
                case ServiceTypeConnection.Rest:
                    break;
            }
            return _serviceConnection;
        }
    }
}
