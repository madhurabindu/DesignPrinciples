# Design Principles

## SOLID Overview
SOLID design principles help us create code that is easy to maintain, easy to extend, easy to read / understand as the software evolves and grows in size.

## S O L I D Principles
1. **S**ingle Responsibility
2. **O**pen/Closed
3. **L**iskov Substitution
4. **I**nterface Segregation
5. **D**ependency Inversion

### Single Responsiblity Principle
<p align="center">
  <i>A class should have one, and only one, reason to change..</i>
</p>


### Open Closed Principle
<p align="center">
  <i>A module should be open for extension but closed for modification.</i>
</p>

We should write our mod- ules so that they can be extended, without requiring them to be modified. In other words, we want to be able to change what the modules do, without changing the source code of the modules.

Is realized using polymorphism, some configuration too can be used for makinb a module open for extension

By using these techniques to conform to the OCP, we can create modules that are extensible, without being changed. This means that, with a little forethought, we can add new features to existing code, without changing the existing code and by only adding new code. This is an ideal situation that can be difficult to achieve, but not impossible.

Even if the OCP cannot be fully achieved, even partial OCP compliance can make dramatic improvements in the structure of an application. It is always better if changes do not propogate into existing code that already works. If you don’t have to change working code, you aren’t likely to break it.


### LISKOV Principle
<p align="center">
  <i>Subclasses should be substitutable for their base classes.</i>
</p>

Derived classes should be substitutable for their base classes. That is, a user of a base class should continue to function properly if a derivative of that base class is passed to it.

An overridden method of a subclass needs to accept the same input parameter values as the method of the superclass. That means you can implement less restrictive validation rules, but you are not allowed to enforce stricter ones in your subclass. 

The return value of a method of the subclass needs to comply with the same rules as the return value of the method of the superclass. You can only decide to apply even stricter rules by returning a specific subclass of the defined return value, or by returning a subset of the valid return values of the superclass.
 
In order to be substitut- able, the contract of the base class must be honored by the derived class.
- Design by Contract: [DoC](./Designbycontract.md) prescribes that software designers should define formal, precise and verifiable interface specifications for software components, which extend the ordinary definition of abstract data types with preconditions, postconditions and invariants. 
This can be summarised by the "three questions" that the designer must repeatedly answer in the contract:
  - What does the contract expect?
  - What does the contract guarantee?
  - What does the contract maintain?

Restating the LSP once again, this time in terms of the contracts, a derived class is substitutable for its base class if:
1. Its preconditions are no stronger than the base class method.
2. Its postconditions are no weaker than the base class method.

### Interface Segregation Principle
<p align="center">
  <i>Many client specific interfaces are better than one general purpose interface</i>
</p>

If you have a class that has several clients, rather than loading the class with all the methods that the clients need, create specific interfaces for each client.

### Dependecy Inversion Principle
<p align="center">
  <i>Depend upon Abstractions. Do not depend upon concretions.</i>
</p>

If the OCP states the goal of OO architecture, the DIP states the primary mechanism. Dependency Inversion is the strategy of depending upon interfaces or abstract functions and classes, rather than upon concrete functions and classes. 

The implication of this principle is quite simple. Every dependency in the design should target an interface, or an abstract class. No dependency should target a concrete class.

Object Creation. One of the most common places that designs depend upon concrete classes is when those designs create instances. By definition, you cannot create instances of abstract classes. Thus, to create an instance, you must depend upon a concrete class. However, there is an elegant solution to this problem named ABSTRACTFACTORY.

# Component Principles
### Cohesion Principles
  - (REP) The Release Reuse Equivalence Principle: The granule of reuse is the granule of release.
  
  - (CCP) The Common Closure Principle: Classes that change together, belong together.
  
  - (CRP) The Common Reuse Principle: Classes that aren’t reused together should not be grouped together
  
These three principles are mutually exclusive. They cannot simultaneously be satis- fied. That is because each principle benefits a different group of people. The REP and CRP makes life easy for reusers, whereas the CCP makes life easier for maintainers. The CCP strives to make packages as large as possible (after all, if all the classes live in just one package, then only one package will ever change). The CRP, however, tries to make packages very small.

### Coupling Principles
  - (ADP) The Acyclic Dependencies Principle: The dependencies betwen packages must not form cycles.
  - 
  - (SDP) The Stable Dependencies Principle: Depend in the direction of stability.
  - 
  - (SAP) The Stable Abstractions Principle: Stable packages should be abstract packages.

## Resources
- https://fi.ort.edu.uy/innovaportal/file/2032/1/design_principles.pdf
- https://www.baeldung.com/solid-principles
- https://www.oodesign.com/single-responsibility-principle.html
