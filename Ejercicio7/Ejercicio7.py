def suma(a, b):
        return a + b

def resta(a, b):
        return a - b

def producto(a, b):
        return a*b

def dividir(a, b):
        return a / b

if __name__ == "__main__":
        a = int(input("ingrese primer numero: "))
        b = int(input("ingrese segundo numero: "))
        print("ELIJA UNA DE LAS OPERACION")
        print("1.- Suma")
        print("2.- Resta")
        print("3.- Producto")
        print("4.- Division")
        op = int(input())
        if op ==1 : print("La suma es: ", suma(a, b))
        elif op == 2 : print("Las resta es: ", resta(a, b))
        elif op == 3 : print("El producto es: ", producto(a, b))
        elif op == 4 : print("La division es: ", dividir(a, b))

