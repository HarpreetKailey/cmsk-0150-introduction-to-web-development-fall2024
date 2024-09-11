"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.hello = void 0;
const world = 'bob';
function hello(who = world) {
    return `Hello ${who}! `;
}
exports.hello = hello;
console.log("Starting...");
console.log(hello("Allan"));
function add(number1, number2) {
    return number1 + number2;
}
