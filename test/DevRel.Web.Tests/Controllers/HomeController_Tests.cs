using System.Threading.Tasks;
using DevRel.Models.TokenAuth;
using DevRel.Web.Controllers;
using Shouldly;
using Xunit;

namespace DevRel.Web.Tests.Controllers
{
    public class HomeController_Tests: DevRelWebTestBase
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