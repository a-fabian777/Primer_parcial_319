
suma :: Int -> Int -> Int
suma a b = a + b
resta :: Int -> Int -> Int
resta a b = a - b
multiplicacion :: Int -> Int -> Int
multiplicacion a b = a * b
division :: Int -> Int -> Int
division a b = div a b

main = do
  print "Ingrese primer numero.."
  x <- getLine
  print "Ingrese segundo numero.."
  y <- getLine
  print "ELIJA UNA OPERACION"
  print "1.-Suma"
  print "2.-Resta"
  print "3.-Producto"
  print "4.-Division"
  ope <- getLine
  case ope of "1" -> putStrLn ("La suma es: " ++ show (suma (read x) (read y)))
              "2" -> putStrLn ("La resta es: " ++ show (resta (read x) (read y)))
              "3" -> putStrLn ("La producto es: " ++ show (multiplicacion (read x) (read y)))
              "4" -> if y == "0"
                        then putStrLn "No se puede dividir entre 0!!!!"
                        else putStrLn ("La division es: " ++ show (division (read x) (read y)))
