 
const person = {
   firstName: "Allan",
   lastName: "Levsen"
}

// non destructuring
const firstName1 = person.firstName;

// destructuring
const {firstName, lastName, age, phone, email } = person;

console.log(firstName1);  // Allan
console.log(firstName);  // Allan


