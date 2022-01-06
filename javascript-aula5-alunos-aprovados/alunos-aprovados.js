function verificarMedia(a, m=7) {
    arrayAlunosAprovados = [];
    for(i = 0; i < a.length; i++) {
        /*if (a[i].media >= m) {
            arrayAlunosAprovados.push(a[i].name);
        }*/
        
        //Object Destructing
        let {name, media} = a[i];
        if (media >= m) {
            arrayAlunosAprovados.push(name);
        }

    }
    return arrayAlunosAprovados;
}

let aluno0 = {name: "João", media: 7}
let aluno1 = {name: "Maria", media: 8}
let aluno2 = {name: "Pedro", media: 6}
let aluno3 = {name: "Zeca", media: 5}
let aluno4 = {name: "Julia", media: 9}

arrayAlunos = [aluno0, aluno1, aluno2, aluno3, aluno4]

console.log(verificarMedia(arrayAlunos)) 