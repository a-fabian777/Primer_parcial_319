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
        print("La suma es: ", suma(a, b))
        print("Las resta es: ", resta(a, b))
        print("El producto es: ", producto(a, b))
        print("La division es: ", dividir(a, b))
