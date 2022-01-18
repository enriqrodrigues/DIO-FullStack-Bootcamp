let lines = gets().split("\n");

let line = lines.shift().split(" ");
//let line = [5, 25]    //teste

let A = parseInt(line[0]);
let B = parseInt(line[1]);

if ( (A % B === 0) || (B % A === 0) ) 
    print( "Sao Multiplos" );
//    console.log("Sao Multiplos");     //teste
else 
    print( "Nao sao Multiplos" );
//    console.log("Nao sao Multiplos");     //teste