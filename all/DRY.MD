# DRY - **D**ont **R**epeat **Y**ourself

## Overview
### Problem statement
When programming large software, it is a poor, but unfortunately common practice to duplicate existing code to place similar logic in a different context. This practice creates potential maintainability issues and also reliability issue. Duplicated code can lead to inconsistencies ( A problem fixed in one of the occurance of duplicate code may not be fixed in other places) and make future changes more challenging (ensuring changes are consistently applied in all occurances).

This results in 
- Maintainance is difficult and error prone
- Maintenance time is increased
- Testing time is increased
- Reliability and confidence in code is reduced 

Code duplication is one of the metrics collected by most od code quality checker tools

### Solution
DRY - is a software development principle that stands for “Don’t Repeat Yourself.” 

## DRY Principle
DRY principle is stated as "Every piece of knowledge must have a single, unambiguous, authoritative representation within a system". 

Living by this principle means that your aim is to reduce repetitive patterns and duplicate code and logic in favor of modular and referenceable code. The way to achieve DRY is by creating functions and classes to reuse and make sure that any logic should be written in only one place. 

WET (which can stand for We Enjoy Typing, Write Every Time, Write Wverything Twice and Waste Everyone’s Time) is when we write the same logic more than once in our code, violating the DRY principle.  It's a tongue-in-cheek reference to code that doesn’t exactly meet the DRY standard. As a result, the code becomes more difficult to read. Furthermore, if we wanted to change the logic, we’d have to make changes to all of its appearances in our codebase, making the code harder to maintain.

**Save time & energy**
DRY code means you get to write duplicate code less often. You're saving lots of time writing the same and fixing same thing in multiple places.

**Create more consistent definitions**
Let's go back to what Andy and Dave said in The Pragmatic Programmer: “Every piece of knowledge must have a single, unambiguous, authoritative representation within a system.” 

By writing DRY definitions for key business logic and metrics that are referenced throughout codebase, one can create those single, unambiguous, and authoritative representations. Gone are the days of 15 different definitions and values for churn, and in are the days of standardization and DRYness.

## Implementing DRY
[Refer this](https://www.plutora.com/blog/understanding-the-dry-dont-repeat-yourself-principle)

## Tools
Based on the language of choice there are many tools available to check duplicate code
Some of the popular ones are
Simian
Sonar
MS near duplicate code detector

## Resources
[https://martinfowler.dev.org.tw/ieeeSoftware/repetition.pdf](https://martinfowler.dev.org.tw/ieeeSoftware/repetition.pdf)
[https://aic-atlas.s3.eu-north-1.amazonaws.com/projects/e7299991-eb2b-4764-a849-4909e01fb07d/documents/Tm74R7Rbi6dKsN4FeEWaUEidvUMcg9Wa3HfyrBrr.pdf](Basic Design Principles)
