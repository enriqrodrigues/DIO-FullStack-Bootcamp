x = gets().split(" ");
//x = [2, 3, 2, 6];   //teste
//console.log(x); //teste

a = parseInt(x[0]);

b = parseInt(x[1]);

c = parseInt(x[2]);

d = parseInt(x[3]);

if ( (b > c) && (d > a) && (c+d > a+b) && (c > 0) && (d > 0)  &&  (a % 2 === 0) )
{
    print("Valores aceitos");
    //console.log("Valores aceitos");   //teste
}else
{
    print("Valores nao aceitos");
    //console.log("Valores nao aceitos");   //teste
}