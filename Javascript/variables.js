
///////////////////////////////////////////////////////////
//
// VARIABLES
//

// four ways to declare variables
//
// 1. using var
//     - can contain letters, digits, 
//       underscores, and dollar signs
//     - must begin with a letter
//     - the equal sign (=) is an "assignment" 
//       operator, not an "equal to" operator

var x = 5;
var total = 6;
var sumOfEverything = x + y;


// 2. using let
//     - let cannot be Redeclared
//     - must be Declared before use
//     - has block scope
let x = 5;
let y = 6;
let z = x + y;


// 3. using nothing
x = 5;
y = 6;
z = x + y;


// 4. using const
//  - must be assigned a value when they are declared
//  - constant values and cannot be changed
//
//    you can NOT:
//    
//    Reassign a constant value
//    Reassign a constant array
//    Reassign a constant object
//
//    But you CAN:
//    
//    Change the elements of constant array
//    Change the properties of constant object

const PI = 3.141592653589793;
PI = 3.14;      // This will give an error
PI = PI + 10;   // This will also give an error

///////////////////////////////////////////////////////////
//
// DATA TYPES
//

// JavaScript has 8 Datatypes
// 1. String
// 2. Number
// 3. Bigint
// 4. Boolean
// 5. Undefined
// 6. Null
// 7. Symbol
// 8. Object
// 
// The Object Datatype
// The object data type can contain:
// 
// 1. An object
// 2. An array
// 3. A date