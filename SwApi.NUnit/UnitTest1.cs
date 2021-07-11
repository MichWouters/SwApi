using System.Threading.Tasks;
using NUnit.Framework;
using SwApi.Services;

namespace SwApi.NUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            SwService service = new SwService();
            var characters = await service.GetStarWarsCharactersAsync();

            Assert.Pass();

        }
    }
}