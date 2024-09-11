
// - Objects are variables. 
// - Objects can contain many values.
// - It is a common practice to declare objects 
//   with the const keyword

// This code assigns many values (Fiat, 500, white) 
// to a variable named car:

const car = {type:"Fiat", model:"500", color:"white"};

// another example
const person = {
   firstName: "John",
   lastName: "Doe",
   age: 50,
   eyeColor: "blue"
};

// The 'name: values' pairs in objects are called properties:
//
//    Property	   Property Value
//    firstName	John
//    lastName	   Doe
//    age	      50
//    eyeColor	   blue

// You can access object properties in two ways:
//
// objectName.propertyName
//       or
// objectName["propertyName"]
//
// ie.   person.lastName;

// Objects can also have methods.
//
// Methods are actions that can be performed on objects.
// Methods are stored in properties as function definitions.
//
//    Property	   Property Value
//
//    fullName	   function() {return this.firstName + " " + this.lastName;}

const employee = {
   firstName: "John",
   lastName : "Doe",
   id       : 5566,
   fullName : function() {
     return this.firstName + " " + this.lastName;
   }
};

// You access an object method with the following syntax:
//
//    objectName.methodName()

employeeName = person.fullName();
console.log(employeeName);
// returns 'John Doe'

// If you access a method without the () parentheses, 
// it will return the function definition:

methodDefinition = person.fullName;
console.log(methodDefinition);
// returns 'function() { return this.firstName + " " + this.lastName; }'


