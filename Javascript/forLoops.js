///////////////////////////////////////////////////////////
//
// FOR LOOPS
//

// Loops can execute a block of code a number of times
// JavaScript supports different kinds of loops:
// 
//  - for      : loops through a block of code a number of times
//  - for/in   : loops through the properties of an object
//  - for/of   : loops through the values of an iterable object
//  - while    : loops through a block of code while a specified 
//               condition is true
//  - do/while : also loops through a block of code while a specified 
//               condition is true

// The for statement creates a loop with 3 optional expressions:
// 
//    for (expression 1; expression 2; expression 3) {
//      // code block to be executed
//    }
// Expression 1 is executed (one time) before the execution of the code block
// Expression 2 defines the condition for executing the code block.
// Expression 3 is executed (every time) after the code block has been executed.

for (let i = 0; i < 5; i++) {
   text += "The number is " + i + "<br>";
}

// From the example above, you can read:
// 
// - Expression 1 sets a variable before the loop starts (let i = 0).
// - Expression 2 defines the condition for the loop to run 
//   (i must be less than 5).
// - Expression 3 increases a value (i++) each time the code block in 
//   the loop has been executed.

