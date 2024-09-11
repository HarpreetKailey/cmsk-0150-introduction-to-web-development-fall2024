
///////////////////////////////////////////////////////////
//
// CONDITIONAL STATEMENTS
//
// Javascript has the following conditional statements:

//    - Use if to specify a block of code to be executed, 
//      if a specified condition is true
//    - Use else to specify a block of code to be executed, 
//      if the same condition is false
//    - Use else if to specify a new condition to test, 
//      if the first condition is false
//    - Use switch to specify many alternative blocks of 
//      code to be executed

// 1. the if statement
//   
//    if (condition) {
//       // block of code to be executed if the condition 
//       // is true
//    }

if (hour < 18) {
   greeting = "Good day";
}

// the else statement to specify a block of code to be 
// executed if the condition is false.

if (hour < 18) {
   greeting = "Good day";
} else {
   greeting = "Good evening";
}

// else if
//
// Use the else if statement to specify a new 
// condition if the first condition is false

if (time < 10) {
  greeting = "Good morning";
} else if (time < 20) {
  greeting = "Good day";
} else {
  greeting = "Good evening";
}


// the switch statement
//
// The switch statement is used to perform different 
// actions based on different conditions
//
// switch(expression) {
//    case x:
//       // code block
//       break;
//    case y:
//       // code block
//       break;
//    default:
//       // code block
//  }

// This is how it works:
// 
// - The switch expression is evaluated once.
// - The value of the expression is compared with the 
//   values of each case.
// - If there is a match, the associated block of code is executed.
// - If there is no match, the default code block is executed.
// 
var today = new Date().getDay();
switch (today) {
   case 1:
     day = "Monday";
     break;
   case 2:
      day = "Tuesday";
     break;
   case 3:
     day = "Wednesday";
     break;
   case 4:
     day = "Thursday";
     break;
   case 5:
     day = "Friday";
     break;
   default:
     day = "Weekend Day";
}

// The break Keyword
//
// When JavaScript reaches a break keyword, it breaks out 
// of the switch block. This will stop the execution inside 
// the switch block.
// 
// It is not necessary to break the last case in a switch block. 
// The block breaks (ends) there anyway.

// The default Keyword
//
// The default keyword specifies the code to run if there is no 
// case match

switch (new Date().getDay()) {
  case 6:
    text = "Today is Saturday";
    break;
  case 0:
    text = "Today is Sunday";
    break;
  default:
    text = "Looking forward to the Weekend";
}


// Common Code Blocks
//
// Sometimes you will want different switch cases to use the same code.
//

// In this example case 4 and 5 share the same code block, 
// and 0 and 6 share another code block
//
switch (new Date().getDay()) {
   case 4:
   case 5:
     text = "Soon it is Weekend";
     break;
   case 0:
   case 6:
     text = "It is Weekend";
     break;
   default:
     text = "Looking forward to the Weekend";
}
