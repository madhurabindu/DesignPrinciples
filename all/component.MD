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
