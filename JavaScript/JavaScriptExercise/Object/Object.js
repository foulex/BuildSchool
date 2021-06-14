var person = {
    name: "Kevin",
    age: 32,
    height: 175,
    weight: 64};
console.log(person);
//var可以重複宣告
var person = {
    name: "Kevin",
    age: 32,
    height: 175,
    weight: 64,
    bmi: function(){
        //object literal語法需要用this才能存取到本身屬性
        return this.weight / ((this.height/100)**2);
    }
};
console.log(person);
console.log(person.bmi());

var person = {
    name: "Kevin",
    age: 32,
    height: 175,
    weight: 64};

console.log(person);
console.log("The Object is "+person);
console.log("This Object is %o", person);

var jsonText =JSON.stringify(person);
console.log(typeof jsonText);

var p = JSON.parse(jsonText);
console.log(p);
console.log(typeof p);