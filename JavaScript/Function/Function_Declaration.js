//Declaration
function circle(r){
    return parseFloat(r) * Math.PI * 2.0;
}

console.log(circle(5.138));
//Expression
var circleArea = function(r){
    return parseInt(r)*Math.PI*2.0;
}

console.log(circleArea(5.138));

console.log(parseFloat(5.138));
console.log(parseInt(5.138));

const getRectArea = function(height, width){
    return height*width;
}

console.log(getRectArea(3,4));
//Arrow
const getRectArea2 = (height, width)=>{
    return height*width;
}

console.log(getRectArea2(3,4));
//Constructor
const computeRectArea = new Function('height','width','return height*width');

console.log(computeRectArea(9,7));
console.log(computeRectArea.name);

const sum =new Function('x','y','{return x+y}');
console.log(sum(8,6));