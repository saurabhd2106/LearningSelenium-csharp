using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace CommonLibs.Contracts
{
	interface IFramesControl
	{
		void SwitchToFrame(IWebElement Element);

		void SwitchToFrame(string Id);

		void SwitchToFrame(int Index);

		void SwitchToParentPage();
	}
}
