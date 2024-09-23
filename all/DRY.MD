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
DRY principle is stated as "Every piece of knowledge must have a single, unambiguous, authoritative representation within a system". It is a software development principle that stands for “Don’t Repeat Yourself.” Living by this principle means that your aim is to reduce repetitive patterns and duplicate code and logic in favor of modular and referenceable code. The way to achieve DRY is by creating functions and classes to reuse and make sure that any logic should be written in only one place. 

WET (which can stand for We Enjoy Typing, Write Every Time, and Waste Everyone’s Time) is when we write the same logic more than once in our code, violating the DRY principle. As a result, the code becomes more difficult to read. Furthermore, if we wanted to change the logic, we’d have to make changes to all of its appearances in our codebase, making the code harder to maintain.

Save time & energy
DRY code means you get to write duplicate code less often. You're saving lots of time writing the same thing over and over. Not only that, but you're saving your cognitive energy for bigger problems you'll end up needing to solve, instead of wasting that time and energy on tedious syntax.

Sure, you might have to frontload some of your cognitive energy to create a good abstraction. But in the long run, it'll save you a lot of headaches. Especially if you're building something complex and one typo can be your undoing.

Create more consistent definitions
Let's go back to what Andy and Dave said in The Pragmatic Programmer: “Every piece of knowledge must have a single, unambiguous, authoritative representation within a system.” As a data person, the words “single” and “unambiguous” might have stood out to you.

Most teams have essential business logic that defines the successes and failures of a business. For a subscription-based DTC company, this could be monthly recurring revenue (MRR) and for a SaaS product, this could look like customer lifetime value (CLV). Standardizing the SQL that generates those metrics is essential to creating consistent definitions and values.

By writing DRY definitions for key business logic and metrics that are referenced throughout a dbt project and/or BI (business intelligence) tool, data teams can create those single, unambiguous, and authoritative representations for their essential transformations. Gone are the days of 15 different definitions and values for churn, and in are the days of standardization and DRYness.

DRY code is a principle that you should always be striving for. It saves you time and energy. It makes your code more maintainable and extensible. And potentially most importantly, it’s the fine line that can help transform you from a good analytics engineer to a great one.

## Tools
Based on the language of choice there are many tools available to check duplicate code
Some of the popular ones are
Simian
Sonar
MS near duplicate code detector

## Resources

# Name

## Overview

## Principle

## Resources
