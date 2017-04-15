# Scheduler-Dotnet
This application has been created following tutorial on this [blog post](https://chsakell.com/2016/06/23/rest-apis-using-asp-net-core-and-entity-framework-core/), 
original code can be found on this [GitHub repository](https://github.com/chsakell/dotnetcore-entityframework-api).
It has been changed in several ways though.

It serves as backend for angular application, that can be found [here](https://github.com/Bielik20/Scheduler-Angular).

### Prerequisites
- [.NET Core](https://www.microsoft.com/net/core) 1.1
- .NET Command Line Tools (1.0.2)

To open solution you will need [Visual Studio 2017](https://www.visualstudio.com/pl/vs/). But it is possible to work with any text editor.

### Installation
First to resotre packages for application (if using Visual Studio 2017 you may skip this stet), from the root folder run:
- `dotnet restore`

Then to create migrations and database, from Scheduler.API run:
- `dotnet ef -p ../Scheduler.Data migrations add initial`
- `dotnet ef -p ../Scheduler.Data database update`

Finally to run application, from Scheduler.API run:
- `dotnet run`

# Knowledge Base
This section contains information and sources which I used while working on this application.

#### Safe Storage
- [Documentation](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets#security-app-secrets)

#### Global Error Handling
- [Documentation](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling#)
- [StackOverflow](http://stackoverflow.com/questions/38014379/error-handling-in-asp-net-core-1-0-web-api-sending-ex-message-to-the-client)

#### Automapper
- [StackOverflow](http://stackoverflow.com/questions/40275195/how-to-setup-automapper-in-asp-net-core)

#### Constraint on the Generic Parameter
- [StackOverflow](http://stackoverflow.com/questions/4737970/what-does-where-t-class-new-mean)

#### Repository Pattern

#### Fluent Validation

#### Cors