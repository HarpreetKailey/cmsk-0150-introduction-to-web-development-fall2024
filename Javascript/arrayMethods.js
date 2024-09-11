
const fruits = ["Banana", "Orange", "Apple", "Mango"];
console.log( fruits.toString() );
// Banana,Orange,Apple,Mango

console.log( fruits.join(" * ") );
// Banana * Orange * Apple * Mango

var len = fruits.length;

var newLength = fruits.push("Kiwi");
console.log(newLength);
// The push() method adds a new element to an array 
// (at the end):
// method returns the new array length:
// returns 5

var poppedValue = fruits.pop();
console.log(poppedValue);
// method returns the value that was "popped out"
// returns Kiwi

let fruit = fruits.shift();
console.log(fruit);
// The shift() method removes the first array element 
// and "shifts" all other elements to a lower index
// returns banana, array is now Orange,Apple,Mango

let newArrayLength = fruits.unshift("Lemon");
console.length(newArrayLength);
// The unshift() method adds a new element to 
// an array (at the beginning)
// returns 5 the new array length

// Merging (Concatenating) Arrays
// The concat() method creates a new array by merging 
// (concatenating) existing arrays:

const myGirls = ["Cecilie", "Lone"];
const myBoys = ["Emil", "Tobias", "Linus"];
const myChildren = myGirls.concat(myBoys);
console.log(myChildren);
// returns Cecilie,Lone,Emil,Tobias,Linus


// Splicing and Slicing Arrays
// The splice() method adds new items to an array.
// The slice() method slices out a piece of an array.

// splice()
// The splice() method can be used to add new items to an array:

fruits.splice(2, 0, "Lemon", "Kiwi");
console.log(fruits);
// returns Banana,Orange,Lemon,Kiwi,Apple,Mango

// - The first parameter (2) defines the position where new elements 
//   should be added (spliced in).
// - The second parameter (0) defines how many elements 
//   should be removed.
// - The rest of the parameters ("Lemon" , "Kiwi") define 
//   the new elements to be added.

// Using splice() to Remove Elements
// With clever parameter setting, you can use splice() to remove elements 
// without leaving "holes" in the array:

fruits.splice(0, 1);
console.log(fruits)
// returns Orange,Apple,Mango


// slice()
// The slice() method slices out a piece of an array into a new array.

// This example slices out a part of an array starting from 
// array element 1 ("Orange"):
// Note
// slice() creates a new array.
// slice() does not remove any elements from the source array.

const citrus = fruits.slice(1);
console.log(fruits);
// notice - banada wasn't removed from the original
// returns Banana,Orange,Apple,Mango

console.log(citrus);
// notice - the new array contains everything starting at
// element 1
// returns Orange,Apple,Mango

// The slice() method can take two arguments like slice(1, 3).
// The method then selects elements from the start argument, 
// and up to (but not including) the end argument.

const citrusFruits = fruits.slice(1, 3);
console.log(citrusFruits);
// returns Orange,Apple
// notice, 1, 3 starts at 1 and ends at 3 BUT DOES NOT
// include element 3