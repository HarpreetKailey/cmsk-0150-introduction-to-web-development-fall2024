Setting up typescript


1. With your project directory set up, you can install TypeScript

   npm i typescript --save-dev

2. With TypeScript installed, you can initialize your TypeScript project by using the following command

   tsc --init

3. Create a new file named helloworld.ts and add the following

      const world = 'world';

      export function hello(who: string = world): string {
        return `Hello ${who}! `;
      }
      console.log("Starting...");
      console.log(hello("Allan"));


4. Open the tsconfig.json and uncomment the following line and change to '\Dist' folder

      "outDir": "./dist", 

5. Open a terminal window, compile the helloworld.ts file using the following command

      tsc

6. To run the program 
      
      node dist/helloworld.js






