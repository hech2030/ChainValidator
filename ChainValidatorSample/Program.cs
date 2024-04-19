using ChainValidator.Validator;
using ChainValidatorSample.Services;
using ChainValidatorSample.UserValidator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");


HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IConfigureValidatorAsync<AddUserRequest, Task<ValidatorResult<bool>>>, AddUserRequestValidator>();


using IHost host = builder.Build();
await ValidatorExample(host.Services);

await host.RunAsync();

async Task ValidatorExample(IServiceProvider hostProvider)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    var validator = provider.GetRequiredService<IConfigureValidatorAsync<AddUserRequest, Task<ValidatorResult<bool>>>>();

    var result = await validator.ValidateConfigureAsync(new AddUserRequest(new ChainValidatorSample.DTO.UserDto()), new CancellationToken());
    if (result.IsSuccess)
    {
        Console.WriteLine("Validation succeded");
    }
    else
    {
        Console.WriteLine($"Validation failed with the following error message: {result.Message}");
    }
}
