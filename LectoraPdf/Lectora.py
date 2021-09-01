import os
from os.path import isfile

import pdfplumber
from Generico import RemoverNumPag, Guardar, cargar, Leer
from Objeto import Estudio

Palabras = cargar("Palabras")
Temario = cargar("Unidad/Info")
ListaTarjetas = {}
for i in Temario.keys():
    Tarjeta = Estudio()
    Tarjeta.SetearAll(Temario[i], Palabras)
    ListaTarjetas[i] = Tarjeta


def AgregarPdf():
    arr = os.listdir("Pdf")
    escaneado = os.listdir("Escaneados")
    for j in Temario.keys():
        arr.remove(j)
    for j in arr:
        print("Escaneando...", j)
        if j not in escaneado:
            with pdfplumber.open(f"Pdf/{j}") as pdf:
                paginas = "".join([RemoverNumPag(k.extract_text()) for k in pdf.pages])
            Guardar(f"Escaneados/{j.replace('.pdf','')}.text", paginas)
        else:
            paginas = Leer(f"Escaneados/{j.replace('.pdf','')}.text")
        Nuevo = Estudio()
        Nuevo.Convertir(paginas)
        Nuevo.GuardarPalabras()
        Nuevo.GuardarInfo(j)
        ListaTarjetas[j] = Nuevo


def Menu():
    o = int(input("0-Agregar pdf\n1-Ver pdf actuales\n2-Ver palabras\n3-Crear Tarjetas\n"))
    if o == 0:
        AgregarPdf()
    if o == 1:
        for i in ListaTarjetas:
            print(i)
    if o == 2:
        for i in Palabras.values():
            print(i)
    if o == 3:
        for i in ListaTarjetas.keys():
            ListaTarjetas[i].SaveTarjeta(i.replace('.pdf', '.text'))
    Menu()


Menu()
