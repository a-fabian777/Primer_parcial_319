open System
let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = a / b 

[<EntryPoint>]
let main argumetos = 
    Console.WriteLine("Introduzca el primer numero")
    let a = Console.ReadLine()
    Console.WriteLine("Introduzca el segundo numero")
    let b = Console.ReadLine()
    
    let n1 = Convert.ToInt32(a)
    let n2 = Convert.ToInt32(b)

    let su = suma n1 n2
    let res = resta n1 n2
    let mlt = multiplicacion n1 n2
    let div = division n1 n2

    Console.WriteLine("La suma es: "+su.ToString())
    Console.WriteLine("La resta es: "+res.ToString())
    Console.WriteLine("El producto es: "+mlt.ToString())
    Console.WriteLine("La division es: "+div.ToString())

    let tecla = Console.ReadKey()
    0
