<div align="center" style="margin-bottom:20px">
  <img src="assets/logo.png" alt="booking-microservices" />
    <div align="center">
           <a href="https://github.com/meysamhadeli/booking-microservices/actions/workflows/ci.yml"><img alt="ci-status" src="https://github.com/meysamhadeli/booking-microservices/actions/workflows/ci.yml/badge.svg?branch=main&style=flat-square"/></a>
                 <a href="https://github.com/meysamhadeli/booking-microservices/blob/main/LICENSE"><img alt="build-status"          src="https://img.shields.io/github/license/meysamhadeli/booking-microservices?color=%234275f5&style=flat-square"/></a>
    </div>
</div>
           
> **The main idea of creating this project is implementing an infrastructure for up and running distributed system with the latest technology and architecture like Vertical Slice Architecture, Event Sourcing, CQRS, DDD, gRpc, MongoDB, RabbitMq, Masstransit in .Net, and we will not deal mainly with business.** 🚀

<a href="https://gitpod.io/#https://github.com/meysamhadeli/booking-microservices"><img alt="Open in Gitpod" src="https://gitpod.io/button/open-in-gitpod.svg"/></a>

# Table of Contents

- [The Goals of This Project](#the-goals-of-this-project)
- [Plan](#plan)
- [Technologies - Libraries](#technologies---libraries)
- [The Domain and Bounded Context - Service Boundary](#the-domain-and-bounded-context---service-boundary)
- [Structure of Project](#structure-of-project)
- [How to Run](#how-to-run)
  - [Docker Compose](#docker-compose)
  - [Kubernetes](#kubernetes)
- [Support](#support)
- [Contribution](#contribution)

## The Goals of This Project

- :sparkle: Using `Vertical Slice Architecture` for architecture level.
- :sparkle: Using `Domain Driven Design (DDD)` to implement all business processes in microservices.
- :sparkle: Using `Rabbitmq` on top of `Masstransit` for `Event Driven Architecture` between our microservices.
- :sparkle: Using `gRPC` for internal communication between our microservices.
- :sparkle: Using `CQRS` implementation with `MediatR` library.
- :sparkle: Using `Postgres` for `write side` of some microservices.
- :sparkle: Using `MongoDB` for `read side` of some microservices.
- :sparkle: Using `Event Store` for `write side` of Booking-Microservice to store all `historical state` of aggregate.
- :sparkle: Using `Inbox Pattern` for ensuring message idempotency for receiver and `Exactly once Delivery`. 
- :sparkle: Using `Outbox Pattern` for ensuring no message is lost and there is at `Least One Delivery`.
- :sparkle: Using `Unit Testing`, `Integration Testing`, `End To End Testing` for testing level.
- :sparkle: Using `Fluent Validation` and a `Validation Pipeline Behaviour` on top of `MediatR`.
- :sparkle: Using `Minimal API` for all endpoints.
- :sparkle: Using `Health Check` for reporting the health of app infrastructure components.
- :sparkle: Using `Docker-Compose` and `Kubernetes` for our deployment mechanism.
- :sparkle: Using `OpenTelemetry` for distributed tracing.
- :sparkle: Using `IdentityServer` for authentication and authorization base on `OpenID-Connect` and `OAuth2`.
- :sparkle: Using `Yarp` as a microservices gateway.

## Plan

> 🌀This project is a work in progress, new features will be added over time.🌀

I will try to register future goals and additions in the [Issues](https://github.com/meysamhadeli/booking-microservices/issues) section of this repository.

High-level plan is represented in the table

| Feature           | Status         |
| ----------------- | -------------- |
| API Gateway       | Completed ✔️   |
| Identity Service  | Completed ✔️   |
| Flight Service    | Completed ✔️   |
| Passenger Service | Completed ✔️   |
| Booking Service   | Completed ✔️   |
| Building Blocks   | Completed ✔️   |

## Technologies - Libraries

- ✔️ **[`.NET 7`](https://dotnet.microsoft.com/download)** - .NET Framework and .NET Core, including ASP.NET and ASP.NET Core
- ✔️ **[`MVC Versioning API`](https://github.com/microsoft/aspnet-api-versioning)** - Set of libraries which add service API versioning to ASP.NET Web API, OData with ASP.NET Web API, and ASP.NET Core
- ✔️ **[`EF Core`](https://github.com/dotnet/efcore)** - Modern object-database mapper for .NET. It supports LINQ queries, change tracking, updates, and schema migrations
- ✔️ **[`Masstransit`](https://github.com/MassTransit/MassTransit)** - Distributed Application Framework for .NET.
- ✔️ **[`MediatR`](https://github.com/jbogard/MediatR)** - Simple, unambitious mediator implementation in .NET.
- ✔️ **[`FluentValidation`](https://github.com/FluentValidation/FluentValidation)** - Popular .NET validation library for building strongly-typed validation rules
- ✔️ **[`Swagger & Swagger UI`](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)** - Swagger tools for documenting API's built on ASP.NET Core
- ✔️ **[`Serilog`](https://github.com/serilog/serilog)** - Simple .NET logging with fully-structured events
- ✔️ **[`Polly`](https://github.com/App-vNext/Polly)** - Polly is a .NET resilience and transient-fault-handling library that allows developers to express policies such as Retry, Circuit Breaker, Timeout, Bulkhead Isolation, and Fallback in a fluent and thread-safe manner
- ✔️ **[`Scrutor`](https://github.com/khellang/Scrutor)** - Assembly scanning and decoration extensions for Microsoft.Extensions.DependencyInjection
- ✔️ **[`Opentelemetry-dotnet`](https://github.com/open-telemetry/opentelemetry-dotnet)** - The OpenTelemetry .NET Client
- ✔️ **[`DuendeSoftware IdentityServer`](https://github.com/DuendeSoftware/IdentityServer)** - The most flexible and standards-compliant OpenID Connect and OAuth 2.x framework for ASP.NET Core
- ✔️ **[`EasyCaching`](https://github.com/dotnetcore/EasyCaching)** - Open source caching library that contains basic usages and some advanced usages of caching which can help us to handle caching more easier.
- ✔️ **[`Mapster`](https://github.com/MapsterMapper/Mapster)** - Convention-based object-object mapper in .NET.
- ✔️ **[`Hellang.Middleware.ProblemDetails`](https://github.com/khellang/Middleware/tree/master/src/ProblemDetails)** - A middleware for handling exception in .Net Core
- ✔️ **[`IdGen`](https://github.com/RobThree/IdGen)** - Twitter Snowflake-alike ID generator for .Net
- ✔️ **[`Yarp`](https://github.com/microsoft/reverse-proxy)** - Reverse proxy toolkit for building fast proxy servers in .NET
- ✔️ **[`Tye`](https://github.com/dotnet/tye)** - Developer tool that makes developing, testing, and deploying microservices and distributed applications easier
- ✔️ **[`gRPC-dotnet`](https://github.com/grpc/grpc-dotnet)** - gRPC functionality for .NET.
- ✔️ **[`EventStore`](https://github.com/EventStore/EventStore)** - The open-source, functional database with Complex Event Processing.
- ✔️ **[`MongoDB.Driver`](https://github.com/mongodb/mongo-csharp-driver)** - .NET Driver for MongoDB.
- ✔️ **[`xUnit.net`](https://github.com/xunit/xunit)** - A free, open source, community-focused unit testing tool for the .NET Framework.
- ✔️ **[`Respawn`](https://github.com/jbogard/Respawn)** - Respawn is a small utility to help in resetting test databases to a clean state.
- ✔️ **[`Testcontainers`](https://github.com/testcontainers/testcontainers-dotnet)** - Testcontainers for .NET is a library to support tests with throwaway instances of Docker containers.

## The Domain And Bounded Context - Service Boundary

- `Identity Service`: The Identity Service is a bounded context for the authentication and authorization of users using [Identity Server](https://github.com/DuendeSoftware/IdentityServer). This service is responsible for creating new users and their corresponding roles and permissions using [.Net Core Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity) and Jwt authentication and authorization.

- `Flight Service`: The Flight Service is a bounded context `CRUD` service to handle flight related operations.

- `Passenger Service`: The Passenger Service is a bounded context for managing passenger information, tracking activities and subscribing to get notification for out of stock products.

- `Booking Service`: The Booking Service is a bounded context for managing all operation related to booking ticket.

![](./assets/booking-microservices.png)

## Structure of Project

In this project I used a mix of [clean architecture](https://jasontaylor.dev/clean-architecture-getting-started/), [vertical slice architecture](https://jimmybogard.com/vertical-slice-architecture/) and I used [feature folder structure](http://www.kamilgrzybek.com/design/feature-folders/) to structure my files.

I used [yarp reverse proxy](https://microsoft.github.io/reverse-proxy/articles/index.html) to route synchronous and asynchronous requests to the corresponding microservice. Each microservice has its dependencies such as databases, files etc. Each microservice is decoupled from other microservices and developed and deployed separately. Microservices talk to each other with Rest or gRPC for synchronous calls and use RabbitMq or Kafka for asynchronous calls.

We have a separate microservice ([IdentityServer](https://github.com/DuendeSoftware/IdentityServer)) for authentication and authorization of each request. Once signed-in users are issued a JWT token. This token is used by other microservices to validate the user, read claims and allow access to authorized/role specific endpoints.

I used [RabbitMQ](https://github.com/rabbitmq) as my MessageBroker for async communication between microservices using the eventual consistency mechanism. Each microservice uses [MassTransit](https://github.com/MassTransit/MassTransit) to interface with [RabbitMQ](https://github.com/rabbitmq) providing, messaging, availability, reliability, etc.

Microservices are `event based` which means they can publish and/or subscribe to any events occurring in the setup. By using this approach for communicating between services, each microservice does not need to know about the other services or handle errors occurred in other microservices.

After saving data in write side, I save a [Internal Command](https://github.com/kgrzybek/modular-monolith-with-ddd#38-internal-processing) record in my Persist Messages storage (like something we do in outbox pattern) and after committing transaction in write side, trigger our command handler in read side  and this handler could save their read models in our MongoDB database.

I treat each request as a distinct use case or slice, encapsulating and grouping all concerns from front-end to back.
When adding or changing a feature in an application in n-tire architecture, we are typically touching many "layers" in an application. We are changing the user interface, adding fields to models, modifying validation, and so on. Instead of coupling across a layer, we couple vertically along a slice. We `minimize coupling` `between slices`, and `maximize coupling` `in a slice`.

With this approach, each of our vertical slices can decide for itself how to best fulfill the request. New features only add code, we're not changing shared code and worrying about side effects.

<div align="center">
  <img src="./assets/vertical-slice-architecture.png" />
</div>

Instead of grouping related action methods in one controller, as found in traditional ASP.net controllers, I used the [REPR pattern](https://deviq.com/design-patterns/repr-design-pattern). Each action gets its own small endpoint, consisting of a route, the action, and an `IMediator` instance (see [MediatR](https://github.com/jbogard/MediatR)). The request is passed to the `IMediator` instance, routed through a [`Mediatr pipeline`](https://lostechies.com/jimmybogard/2014/09/09/tackling-cross-cutting-concerns-with-a-mediator-pipeline/) where custom [middleware](https://github.com/jbogard/MediatR/wiki/Behaviors) can log, validate and intercept requests. The request is then handled by a request specific `IRequestHandler` which performs business logic before returning the result.

The use of the [mediator pattern](https://dotnetcoretutorials.com/2019/04/30/the-mediator-pattern-in-net-core-part-1-whats-a-mediator/) in my controllers creates clean and [thin controllers](https://codeopinion.com/thin-controllers-cqrs-mediatr/). By separating action logic into individual handlers we support the [Single Responsibility Principle](https://en.wikipedia.org/wiki/Single_responsibility_principle) and [Don't Repeat Yourself principles](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself), this is because traditional controllers tend to become bloated with large action methods and several injected `Services` only being used by a few methods.

I used CQRS to decompose my features into small parts that makes our application:

- Maximize performance, scalability and simplicity.
- Easy to maintain and add features to. Changes only affect one command or query, avoiding breaking changes or creating side effects.
- It gives us better separation of concerns and cross-cutting concern (with help of mediatr behavior pipelines), instead of bloated service classes doing many things.

Using the CQRS pattern, we cut each business functionality into vertical slices, for each of these slices we group classes (see [technical folders structure](http://www.kamilgrzybek.com/design/feature-folders)) specific to that feature together (command, handlers, infrastructure, repository, controllers, etc). In our CQRS pattern each command/query handler is a separate slice. This is where you can reduce coupling between layers. Each handler can be a separated code unit, even copy/pasted. Thanks to that, we can tune down the specific method to not follow general conventions (e.g. use custom SQL query or even different storage). In a traditional layered architecture, when we change the core generic mechanism in one layer, it can impact all methods.

## How to Run

> ### Docker

#### Config Certificate
Run the following commands to [Config SSL](https://docs.microsoft.com/en-us/aspnet/core/security/docker-compose-https?view=aspnetcore-6.0) in your system

#### Windows using Linux containers
```bash
dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\aspnetapp.pfx -p password
dotnet dev-certs https --trust
```
> Note: for running this command in `powershell` use `$env:USERPROFILE` instead of `%USERPROFILE%`

#### macOS or Linux
```bash
dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx -p $CREDENTIAL_PLACEHOLDER$
dotnet dev-certs https --trust
```
#### Docker Compose

Run this app in docker using the [docker-compose.yaml](./deployments/docker-compose/docker-compose.yaml) file with the below command at the root of the application:

```bash
docker-compose -f ./deployments/docker-compose/docker-compose.yaml up -d
```

> ### Kubernetes
For Configure TLS in kubernetes cluster we need install `cert-manager` base on [docs](https://cert-manager.io/docs/installation) and run the following commands for apply TLS in our application

```bash
kubectl apply -f ./deployments/kubernetes/booking-cert-manager.yml
```
> Note: Also, we can run this commands for creating new `tls.key` and `tls.crt` and replace them with old one in `booking-cert-manager.yml` section `secret`
```bash
openssl req -x509 -newkey rsa:4096 -sha256 -nodes -keyout tls.key -out tls.crt -subj "/CN=booking-microservices.com" -days 365

kubectl create secret tls booking-tls --key tls.key --cert tls.crt
```

Run the following command to apply all deployments, pods, services, ingress and configmaps that we need
```bash
kubectl apply -f ./deployments/kubernetes/booking-microservices.yml
```

### Documentation Apis

Each microservice uses swagger open api, navigate to /swagger for a list of every endpoint.
For testing apis I used the [REST Client](https://github.com/Huachao/vscode-restclient) plugin for VS Code running this file [booking.rest](./booking.rest).

# Support

If you like my work, feel free to:

- ⭐ this repository. And we will be happy together :)

Thanks a bunch for supporting me!

## Contribution

Thanks to all [contributors](https://github.com/meysamhadeli/booking-microservices/graphs/contributors), you're awesome and this wouldn't be possible without you! The goal is to build a categorized, community-driven collection of very well-known resources.

## Project References & Credits

- [https://github.com/jbogard/ContosoUniversityDotNetCore-Pages](https://github.com/jbogard/ContosoUniversityDotNetCore-Pages)
- [https://github.com/kgrzybek/modular-monolith-with-ddd](https://github.com/kgrzybek/modular-monolith-with-ddd)
- [https://github.com/oskardudycz/EventSourcing.NetCore](https://github.com/oskardudycz/EventSourcing.NetCore)
- [https://github.com/thangchung/clean-architecture-dotnet](https://github.com/thangchung/clean-architecture-dotnet)
- [https://github.com/jasontaylordev/CleanArchitecture](https://github.com/jasontaylordev/CleanArchitecture)
- [https://github.com/pdevito3/MessageBusTestingInMemHarness](https://github.com/pdevito3/MessageBusTestingInMemHarness)
- [https://github.com/devmentors/FeedR](https://github.com/devmentors/FeedR)

## License
This project is made available under the MIT license. See [LICENSE](https://github.com/meysamhadeli/booking-microservices/blob/main/LICENSE) for details.
