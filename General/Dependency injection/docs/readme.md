Here is the summary of the differences between scoped, singleton, and transient dependencies in .NET:

## Singleton
   - Singleton is a service that has only one instance in the entire application.
   - Each request receives the same instance of the object.
   - Useful for services that do not store state or request-specific data.

## Transient
   - Transient service is created every time it is required.
   - Each request receives a new, separate instance of the object.
   - Useful for services that do not store state or request-specific data.

## Scoped
   - Scoped service is created once per request (e.g., per session, per controller).
   - All requests within the same session/controller receive the same instance of the object.
   - Useful for services that store state or request-specific data.

In summary, scoped is an intermediate solution between singleton and transient. It allows maintaining state within a single request, but not for the entire duration of the application.

### Links:
- [Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
- [James Montemagno - Singleton vs Transient - What's the Difference in .NET Dependency Injection?](https://youtu.be/oC5zpEbwViE)
- [James Montemagno - What is a Scoped .NET Dependency, and Why You Should Use Them](https://youtu.be/HMN26wQ8J54)
- [Bald. Bearded. Builder. - Should my Services be Transient, Scoped, or Singleton?](https://youtu.be/ToFqISWq4is)
- [Amichai Mantinband - Dependency Injection Deep Dive | .NET & C# Essentials
](https://youtu.be/yjUCKSKCQxg)