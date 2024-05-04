using Application.Interfaces.TBOS.Masters.Customer;
using Domain.Settings;
using Infrastructure.Persistance.Services.TBOS.Masters.Branch;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Services.TBOS.Masters.Customer
{
    public class CustomerMasterService : DABase, ICustomerMaster
    {
        APISettings _settings;
        private ILogger<CustomerMasterService> _logger;

        private const string SP_BranchMaster_Insert = "master.BranchMaster_Insert";

        public CustomerMasterService(IOptions<ConnectionSettings> connectionSettings, ILogger<CustomerMasterService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }
    }
}
