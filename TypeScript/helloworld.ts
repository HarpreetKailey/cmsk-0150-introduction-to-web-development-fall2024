
const world = 'bob';

export function hello(who: string = world): string {
  return `Hello ${who}! `;
}
console.log("Starting...");
console.log(hello("Allan"));


function add(number1: number, number2: number): number {
  return number1 + number2;
}



