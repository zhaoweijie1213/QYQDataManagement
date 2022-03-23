using System;
using QYQ.DataManagement.Localization;
using QYQ.DataManagement.Localization.Extensions;
using Shouldly;
using Volo.Abp.Localization;
using Xunit;

namespace QYQ.DataManagement.Localizations
{
    public class LocalizationHelper_Tests:DataManagementDomainTestBase
    {
        [Fact]
        public void Test_LocalizationHelper_L_OK()
        {
            using (CultureHelper.Use("en"))
            {
                var enValue = LocalizationHelper.L["Welcome"];
                enValue.Value.ShouldBe("Welcome");
            }

            using (CultureHelper.Use("zh-Hans"))
            {
                 
                var enValue = LocalizationHelper.L["Welcome"];
                enValue.Value.ShouldBe("欢迎");
            }  
        }
        
        [Fact]
        public void Test_ToLocalicationDescription_L_OK()
        {
            var test = new {TestType=TestType.Cancel};
            using (CultureHelper.Use("en"))
            {
                var enValue = test.TestType.ToLocalicationDescription();
                enValue.ShouldBe("Cancel");
            }

            using (CultureHelper.Use("zh-Hans"))
            {
                 
                var enValue = test.TestType.ToLocalicationDescription();
                enValue.ShouldBe("取消");
            }  
        }
    }
}