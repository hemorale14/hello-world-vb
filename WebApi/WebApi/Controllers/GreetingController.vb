Imports Microsoft.AspNetCore.Mvc

<ApiController>
<Route("[controller]")>
Public Class GreetingController
    Inherits ControllerBase

    <HttpGet>
    Public Function GetHello() As String()
        Return New String() {"Hello World VB/ASP.NET Core web API!", "Alumno: Hector Rocha Morales", "Materia: Contenedores", "Universidad Internacional de La Rioja en México"}
    End Function
End Class
