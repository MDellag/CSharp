import pynput.keyboard

import tkinter as tk
#from tkinter import *

keyCount = 0

#Main Function of the program
def process_key_press(key):
    
    global keyCount
    keyCount += 1 
    num.set(keyCount) 
    



#funcion para el Boton
def resetKeyCount():
    global keyCount
    keyCount = 0 
    num.set(keyCount)   



ventana = tk.Tk()
num = tk.IntVar(value=keyCount)

ventana.title("KeyHandler")
ventana.geometry('200x175') #AnchoXAlto
ventana.configure(background = 'snow')

etiqueta = tk.Label(ventana, textvariable = num, bg = "snow", fg = "black", font = ("Times 22 bold"))
boton = tk.Button(ventana, text = "Reset", font = ("Times 13 bold"), bg = "green", fg = "snow", command = resetKeyCount )
etiqueta.pack(padx = 61, pady = 66)
boton.pack() #al declarar un boton o label, etc.. no olvidar el .pack que hace que lo cree

#posiciona el boton, si no se pone X e Y queda posicionado inicialmente en una esquina superior izquierda
boton.place( height=30, width=70, x = 120, y = 130)
 

keyboard_listener = pynput.keyboard.Listener(on_release = process_key_press)


#2 threads at same time
with keyboard_listener:
    while ventana.mainloop():
        keyboard_listener.join()
    

   
    
 

