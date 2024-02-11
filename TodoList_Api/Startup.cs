using Microsoft.EntityFrameworkCore;
using TodoListAPI.Data;

public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<TodoContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("TodoContext")));
}