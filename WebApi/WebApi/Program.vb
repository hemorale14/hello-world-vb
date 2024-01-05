Imports System
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.Extensions.DependencyInjection

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        builder.Services.AddControllers()
        builder.Services.AddEndpointsApiExplorer()

        Dim app = builder.Build()

        'app.MapGet("/", Function() "Hello World!")

        app.UseHttpsRedirection()
        app.UseAuthorization()
        app.MapControllers()

        app.Run()
    End Sub
End Module
