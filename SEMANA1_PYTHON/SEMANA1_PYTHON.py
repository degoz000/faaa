import math


def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido al curso de fudamentos de algoritmo de la carrera {carrera}")

def ejer2():
    print ("\"Diego\"")

def ejer3():
 num1=int(input("ingrese número1"))
 num2=int(input("ingrese el numero 2"))

 print("Suma" , (num1+num2))
 print("Resta" , (num1-num2))
 print("Multiplicación" , ( num1*num2))
 print("División" , (num1/num2))


 import match #importado librería math

 def ejer4():
     num =float(input("ingrese número decimal: "))
     raiz= math.sqrt(num)
     redo= round(num,2)
     cubo = math.pow(num,3)
     cubica = num ** (1/3)
     print("raiz cuadrada : ",raiz)
     print("redondeado : ",cubo)
     print("al cubo: ",cubo)
     print ("raíz cubica : ",cubica)


     def ejer5():
         num=input("ingrese un número : ")

         entero=int(num)
         decim=float(num)

         print("Resto : ", (entero%2))
         print("Decimal : ", (decim/3))
