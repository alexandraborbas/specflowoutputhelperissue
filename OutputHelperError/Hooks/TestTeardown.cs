using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace OutputHelperError.Hooks
{
    [Binding]
    public class TestTeardown
    {
        private readonly ISpecFlowOutputHelper _helper;

        public TestTeardown(ISpecFlowOutputHelper helper)
        {
            _helper = helper;
        }

        [AfterScenario(Order = 0)]
        public void Foo()
        {
        }
    }
}
