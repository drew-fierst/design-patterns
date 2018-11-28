Exercise 4 Solution
===================

**NOTE: this is only one possible solution. Many valid solutions may exist. It is often helpful to discuss their respective merits.**

The Strategy pattern can be used to implement the different payment algorithms for each type if invoicing.

The Chain of Responsibility pattern can be used for calculating the charges for each service used by a particular contract.

The contract would reference the relevant payment algorithm for the contract's client, as well as which services are included in the contract. The chain of service calculators would then be constructed and the contract and payment algorithm passed in to the Compute() method. Each calculator would get the charge from the next handler (if there is one) and return that value plus its own charges.
