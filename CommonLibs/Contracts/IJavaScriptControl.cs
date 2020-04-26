using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs.Contracts
{
	interface IJavaScriptControl
	{

		void executeJavaScript(string scriptToExecute);

		void scrollDown(int x, int y);

        string executeJavaScriptWithReturnValue(string scriptToExecute);

	}
}
