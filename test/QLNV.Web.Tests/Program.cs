using Microsoft.AspNetCore.Builder;
using QLNV;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("QLNV.Web.csproj"); 
await builder.RunAbpModuleAsync<QLNVWebTestModule>(applicationName: "QLNV.Web");

public partial class Program
{
}
