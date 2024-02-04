function converter(){
    let i = 0;
    Object.keys(example).forEach(key => { 
        console.log(key, example[key])
        converted[i][0]
        i++;
        console.log(converted[i])
    });     
    Object.values(example).forEach(val => { console.log(val)});     
    Object.entries(example).forEach(entry => {
        const [key, value] = entry;
        console.log(key, value);
      });
}