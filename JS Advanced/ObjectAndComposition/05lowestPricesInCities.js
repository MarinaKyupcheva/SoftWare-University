function solve(input) {
let sell = {};

while(input.length){
let part = input.shift();
let[town, product, price] = part.split(' | ');
price = Number(price);

if(!sell[product]){
sell[product] = {town, price};
} else{
sell[product] = (sell[product].price <= price) 
? sell[product] : { town, price};
}
}
let result = [];

for (const product in sell) {
    result.push(`${product} -> ${sell[product].price} (${sell[product].town})`);
        
    }
    return result.join('\n');
}





console.log(solve(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']));