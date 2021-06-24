let promise1= new Promise((resolve,reject)=>{
    console.log('Promise初始化');
    resolve();
})

promise1
    .then(()=>{
        console.log('這是第一個then區段');
        throw new Error('fail');
    })
    .catch(()=>{
        console.log('這是第一個catch區段');
    })
    .then(()=>{
        console.log('這是第二個then區段');

    })
    .finally()