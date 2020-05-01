using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs.Contracts
{
    interface IAlertControl
    {

        void AcceptAlert();

        void DismissAlert();

        string GetMessageFromAlert();

        bool CheckAlertIsPresent(int timeoutInSeconds);

    }
}
