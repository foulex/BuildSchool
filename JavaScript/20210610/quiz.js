let Zodiac = ['鼠', '牛', '虎', '兔', '龍', '蛇', '馬', '羊', '猴', '雞', '狗', '豬'];
let quiz = ['豬', '龍', '鼠', '狗', '羊', '雞', '馬'];
let quiz_ans = quiz.sort((a, b) => { return Zodiac.indexOf(a)-Zodiac.indexOf(b) });
console.log(quiz_ans);