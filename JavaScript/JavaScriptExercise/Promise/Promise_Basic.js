const promise1 = new Promise(function (resolve, reject) {
    setTimeout(() => {
        resolve("Success!");
        reject("執行失敗");
    }, 1000)
});

console.log(promise1);

promise1
    .then(result => {
        console.log(result);
    })
    .catch(ex => {
        console.log("失敗原因:" + ex);
    })
    .finally(() => {
        console.log(promise1);
        console.log("finally完成");
    });