function isPrime(num: number): boolean{
		const ints = [ 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 ];

		for (const i of ints){
			if (num == i)
				return true;
		}
		return false;
}


const reader = require("prompt-sync")();
var tried = 0;
var num = 0;
var input: number;

var CountPrimes = 0;
var SumEven = 0;
var MaxOdd = 0;
var SumDivBy7 = 0;

// sanitize user input
console.log("Enter a number between 10 and 200: ");
while (tried < 3){

	let userInput = reader();
	if (userInput == null){
		process.exit(0);
	}
	var num = parseInt(userInput, 10);

	console.log(!isNaN(input))
	if (!isNaN(num))
	{
		if ((num < 10) || (num > 200)){
			process.stdout.write("Invalid range. Input again:");
			tried++;
			continue;
		}
		break;
	}
	else
	{
		console.log("Enter an integer please");
		tried++;
	}
}
if (tried == 3){
	console.log("");
	console.log("Too many attempts exit.");
	process.exit(0);
}

var i:number;
for (i = 1; i <= num; i++){
	if(isPrime(i)){
		process.stdout.write("[" + i + "] ");
		CountPrimes++;
	}
	else if(((i % 3) == 0) && ((i % 5) == 0)){
		process.stdout.write("FizzBuzz ");
	}
	else if((i % 3) == 0){
		process.stdout.write("Fizz ");
	}
	else if((i % 5) == 0){
		process.stdout.write("Buzz ");
	}
	if((i % 7) == 0){
		SumDivBy7+=i;
	}
	if((i % 2) == 0){
		SumEven+=i;
		process.stdout.write(i + " ");
	}
	else{
		MaxOdd = (i > MaxOdd) ? i : MaxOdd;
		process.stdout.write(i + " ");
	}
}
console.log();
console.log("Count primes: " + CountPrimes);
console.log("Sum Even: " + SumEven);
console.log("Max Odd: " + MaxOdd);
console.log("Sum Div by 7: " + SumDivBy7);


