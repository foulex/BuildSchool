var Cars = ["BMW", "BENZ", "AUDI", "LEXUS"];

//1.find()
let car = Cars.find(c => c == "AUDI");
console.log(car);

//2.indexOf
let index = Cars.indexOf("LEXUS");
console.log(index);

//3.findIndex()
let idx = Cars.findIndex(c => c == "BENZ");
console.log(idx);

//4.filter
let Prices = [280, 320, 250, 210];
let result = Prices.filter(p => p > 260);
console.log(result);

var Cars = ["BMW", "BENZ", "AUDI", "LEXUS"];
Prices.filter(function (price, index) {
    if (price > 250) {
        console.log(Cars[index] + "的價格是" + price);
    }
});