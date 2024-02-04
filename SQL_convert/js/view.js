updateView();

function updateView(){
html = `<div>hello ${example.x1y1.correct}</div>`;
    app.innerHTML = html;
    
}


converter(example);
function converter(example){
    let i = 0;
    Object.keys(example).forEach(key => { 
        //console.log(key, example[key])
        converted.length = i+1;
        converted[i] = [key];
       
        Object.values(example).forEach(val => { console.log(val.state)});
        let stateBit; 
        switch(example[key].state){
            case "empty":
                stateBit = 0;
                break;
            case "filled":
                stateBit = 1;
                break;
            case "filledx":
                stateBit = 2;
                break
        }
        converted[i][1]= stateBit;
        Object.values(example).forEach(val => { console.log(val.correct)}); 
        let correctBit;
        switch(example[key].correct){
            case true:
                correctBit = 1;
                break;
            case false:
                correctBit = 0;
                break;
        }
        converted[i][2] = correctBit;
        
        i++;
    });  
    console.log(converted)   
}