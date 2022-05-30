using System.Threading.Tasks;
using ems.Models.TokenAuth;
using ems.Web.Controllers;
using Shouldly;
using Xunit;

namespace ems.Web.Tests.Controllers
{
    public class HomeController_Tests: emsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}