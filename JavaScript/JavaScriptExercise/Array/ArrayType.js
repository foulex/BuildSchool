var array1 =[1,3,5,7];

console.log(array1 instanceof Array);
console.log(Array.isArray(array1))

createRow(array1);

function createRow(dataArray){
    if(Array.isArray(array1)==false){
        return;
    }
}