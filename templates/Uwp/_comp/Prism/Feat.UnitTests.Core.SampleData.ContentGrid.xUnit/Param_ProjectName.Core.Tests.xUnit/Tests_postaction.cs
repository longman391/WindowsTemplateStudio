﻿//{[{
using Param_RootNamespace.Core.Services;
//}]}

namespace Param_RootNamespace.Core.Tests.XUnit
{
    public class Tests
    {
        //^^
        //{[{

        // TODO WTS: Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public void EnsureSampleDataServiceReturnsContentGridData()
        {
            var dataService = new SampleDataService();
            var actual = dataService.GetContentGridData();

            Assert.NotEmpty(actual);
        }
        //}]}
    }
}
