using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Braintree;

namespace Rockz_Utility.BrainTree
{
    public interface IBrainTreeGate
    {
        IBraintreeGateway CreateGateway();

        IBraintreeGateway GetGateway();
    }
}
