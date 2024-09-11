const LoadTodo = async () => {
  
   console.log('Start of Async function...'); 
   
   const url = `https://jsonplaceholder.typicode.com/todos/1`;
   const res = await fetch(url);
   if (res.ok) {
     const data = await res.json();
     console.log('res ok, returning data'); 
     return data;
   }
 
   console.log('res is NOT okay, end of Async Function');
 
 };
 
 LoadTodo().then((data) => console.log(data));
 //console.log('End of program');