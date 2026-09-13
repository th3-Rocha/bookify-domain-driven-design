#  Bookify - Booking System API

A enterprise-grade booking management web API built with **.NET 8**, focusing on **Clean Architecture**, **Domain-Driven Design (DDD)**, and **CQRS** patterns.

## Architectural Highlights

* **Clean Architecture**: Separation of concerns into distinct layers (Domain, Application, Infrastructure, Presentation).
* **Domain-Driven Design (DDD)**: Rich domain models, Aggregate Roots, Encapsulated Entities, and Value Objects.
* **Domain Events**: Decoupled side effects driven by domain changes handled via MediatR (`IDomainEvent`).
* **Functional Error Handling**: Custom **Result Pattern** (`Result` & `Result<TValue>`) avoiding costly exception throwing for control flow.
* **Rich Domain Errors**: Strongly-typed static errors avoiding magic strings and unifying domain failure responses.

##  Tech Stack & Patterns

* **Language/Framework**: C# / .NET 8
* **Messaging & CQRS**: MediatR
* **Code Analysis**: Custom Roslyn and Sonar rules configured for DDD pragmatism via `.editorconfig`
