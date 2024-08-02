## Design by Contract

The design by contract method of interface contract design was developed for designing the interfaces of classes, but the principles fit service interface design equally well, although with a different slant. Design by contract for interface design is based on six principles:

The main principles of this model are threefold:

1. Preconditions: 
    - the client is obligated to meet a function's required preconditions before calling a function. 
    - If the preconditions are not met, then the function may not operate correctly.
2. Postconditions: 
    - the function guarantees that certain conditions will be met after it has finished its work.
    - If a postcondition is not met, then the function did not complete its work correctly.
3. Class invariant: 
    - constraints that every instance of the class must satisfy. 
    - This defines the state that must hold true for the class to operate according to its design.

Design by Contract: DoC prescribes that software designers should define formal, precise and verifiable interface specifications for software components, which extend the ordinary definition of abstract data types with preconditions, postconditions and invariants. 

This can be summarised by the "three questions" that the designer must repeatedly answer in the contract:
  - What does the contract expect?
  - What does the contract guarantee?
  - What does the contract maintain?

#### 1. Separate basic queries from derived queries.

Derived queries can be specified in terms of basic queries. A derived query is a query that uses other queries to obtain an ultimate answer. A basic query goes directly after the data source to get the data. 

Consider a bank account service that supports all the account activity for a bank, including checking and savings accounts.
 If a client needs to get the balance of the account, it calls the GetBalance service. 
This method inquires about the account holder's checking and savings account balances, sums them, and returns the result. 
If all the client needs is the total balance, there would never be a problem. 
If, however, a client needs just the checking account balance, the service will not fulfill this need. 

Therefore, it is necessary to separate the “basic” queries of GetBalance for savings and checking accounts from the composite derived query for both accounts.

 A correct design would consist of three service interfaces: GetBalance on a checking account service, on a savings account service, and on a composite BankAccount service. 

The composite derived service method would use the basic queries to derive the data on the client's behalf.

#### 2. For each command, write a postcondition that specifies the value of every basic query.

 A postcondition specifies the effect of calling a feature of the service.

 For instance, a Withdraw command on a checking account service will guarantee that if the method succeeds, the GetBalance query will return the previous balance minus the withdrawal amount.

#### 3. For every query command, decide on a suitable precondition.

 For methods that require multiple steps, specify the preconditions necessary for the multiple steps to succeed. 

For instance, consider a credit-card validation sequence where the first step is a validation that the cardholder has not exceeded his or her credit limit for the transaction. The second method actually confirms the transaction. 

The precondition for the confirm transaction has with it a precondition that the validate transaction has already occurred.

#### 4. For each derived query, write a postcondition that specifies what result will be returned in terms of one or more basic queries.

 If we know the values of the basic queries, we will know the values of the derived queries. 

For instance, in the previous example, the postcondition for the GetBalance method on the derived BankAccount service specifies that the result is the sum of the GetBalance method on the checking account service and that on the savings account service.

#### 5. Separate queries from commands.

 The first principle of writing interface contracts is to separate queries from commands. 

A query inspects the state of the service, and a command updates the state of a service. 

For example, consider a bank account service. A GetBalance query retrieves the state of the bank account service. 
The command Withdraw updates the state of the balance in the account. 
A bad design would return the new balance in the account when Withdraw was called. 
This would combine the query with the command. 
The reason this is undesirable is that a user will be tempted to call the Withdraw method to query the balance of the account and thus inadvertently cause the state of the service to change.
 The Withdraw method should return only the result of the service call, such as “OK” or “Fail.”

##### 6. Write invariants to define unchanging properties of objects.

 For instance, the account balance in the savings account service can never be less than zero. Having these invariants specified somewhere helps define all possible states of the service, so proper error handling can be built.
