# Music Royalty Engine

A robust, enterprise-grade music royalty calculation engine built with .NET 8 and Clean Architecture principles.

## Architectural Decision Records (ADR)

### 1. Choice of .NET 8
- **Context**: High-performance backend development requiring modern language features and long-term support (LTS).
- **Decision**: Adopted .NET 8 for its exceptional execution speed, native dependency injection container, and robust support for enterprise standards.
- **Consequences**: Ensures clean codebase maintainability, minimized memory overhead, and seamless integration with modern cloud-native deployment options.

### 2. Adoption of Clean Architecture
- **Context**: The domain logic of royalty calculation involves complex rules that must remain isolated from external technical frameworks or databases.
- **Decision**: Implemented Clean Architecture to strictly separate the Core domain logic from the API delivery mechanism and Infrastructure persistence layers.
- **Consequences**: High testability of business logic, decoupling of technical concerns, and long-term flexibility in swapping databases or UI frameworks without affecting core rules.