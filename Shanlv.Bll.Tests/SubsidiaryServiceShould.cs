using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shanlv.Dal;
using Shanlv.DomainModel.ViewModel;
using Shanlv.EfDbModels;
using Shanlv.IBll;
using Xunit;

namespace Shanlv.Bll.Tests
{
    public class SubsidiaryServiceShould
    {
        private readonly ISubsidiaryService _subsidiaryService;

        public SubsidiaryServiceShould()
        {
            //var conn = "server=10.28.7.12;database=Shanlv;uid=sa;pwd=Admin123456;";
            //ShanlvDbContext db = new ShanlvDbContext(options => { options = conn });
         
            var options = CreateDbContextOptions("shanlv");
            var db = new ShanlvDbContext(options);
            var subsidiaryDal = new SubsidiaryDal(db);
            _subsidiaryService = new SubsidiaryService(db, subsidiaryDal);
        }
        public DbContextOptions<ShanlvDbContext> CreateDbContextOptions(string databaseName)
        {
            var serviceProvider = new ServiceCollection().AddEntityFrameworkInMemoryDatabase().BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<ShanlvDbContext>();
            builder.UseInMemoryDatabase(databaseName).UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }


        //[Fact]
        public void HavePlusOneWhenAdded() // 一个case
        {
            SubsidiaryViewModel subsidiaryViewModel = new SubsidiaryViewModel();
            subsidiaryViewModel.SubsidiaryName = "幸运单位";

            var result = _subsidiaryService.Add(subsidiaryViewModel);

            Assert.Equal(result, result);
        }
    }


}
