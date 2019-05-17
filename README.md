# SOLID Principles

SOLID Principles are the acronym for five design principles which was introduced by Robert C Martin (Uncle Bob). These are the fundamental principles of which let you write your more which makes are more understandable in a specific context, flexible and maintainable in the long run.

# SOLID Principles


## Single Responsibility Principle (SRP):

The single responsibility principle is a computer programming principle that states that every module, class, or function should have responsibility over a single part of the functionality provided by the software,
and that responsibility should be entirely encapsulated by the class. All its services should be narrowly aligned with that responsibility.

In Short, A class should have only one reason to change. A class should have only a single responsibility, that is, only changes to one part of the software's specification should be able to affect the specification of the class.

## Open–Closed Principle (OCP):

In object-oriented programming, the open/closed principle states "software entities should be open for extension, but closed for modification";
that is, such an entity can allow its behaviour to be extended without modifying its source code.

In Short, Software entities (like classes & interfaces) should be open for extension, but closed for modification.

## Liskov Substitution Principle (LSP):

Substitutability is a principle in object-oriented programming stating that, in a computer program, if S is a subtype of T, then objects of type T may be replaced with objects of type S without altering any of the desirable properties of the program.

In Short, "Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program." See also design by contract.

## Interface Segregation Principle (ISP):

In the field of software engineering, the interface-segregation principle (ISP) states that no client should be forced to depend on methods it does not use.

ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them.

ISP is intended to keep a system decoupled and thus easier to refactor, change, and redeploy.

In Short, Many client-specific interfaces are better than one general-purpose interface.

## Dependency Inversion Principle (DIP):

In object-oriented design, the dependency inversion principle is a specific form of decoupling software modules.

High-level modules should not depend on low-level modules implementation details. Both should depend on abstractions (e.g. interfaces).
Abstractions should not depend on details. Details (concrete implementations) should depend on abstractions.

In short, One should "depend upon abstractions like interfaces or abstract classes, [not] concretions like (concrete class).
