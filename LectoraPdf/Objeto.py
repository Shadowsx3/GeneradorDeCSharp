from Generico import Reemplazo, GuardarJ, MaxLargo, Guardar, is_cjk


class Estudio:
    _info = {}
    _palabras = {}

    def SetInfo(self, xtipo, xtema, xleccion, xlibro, xcategoria):
        self._info = {
            "Tipo": xtipo,
            "Tema": Reemplazo(xtema, "Tema"),
            "Lección": Reemplazo(xleccion, "Lección"),
            "Libro de texto": Reemplazo(xlibro, "Libro de texto :"),
            "Categoría gramatical": Reemplazo(xcategoria, "Categoría gramatical :")
        }

    def SetInfos(self, diccionario):
        self._info = diccionario

    def SetPalabras(self, diccionario):
        for i in self._info["Palabras"]:
            self._palabras[i] = diccionario[i]

    def SetearAll(self, info, palabras):
        self.SetInfos(info)
        self.SetPalabras(palabras)

    def Convertir(self, texto):
        cadena = [i for i in texto.split("\n") if i != ""]
        self.SetInfo(cadena.pop(0), cadena.pop(0), cadena.pop(0), cadena.pop(0), cadena.pop(0))
        while not is_cjk(cadena[0][0]):
            self._info["Categoría gramatical"] += cadena.pop(0)
        while len(cadena) != 0:
            linea = cadena.pop(0).split(" ")
            if not cadena:
                break
            japones = linea.pop(0)
            if len(linea[0]) != 0:
                if is_cjk(linea[0][0]):
                    japones += f' {linea[0]}'
                    linea.pop(0)
            spanish = " ".join(linea)
            pronunciation = cadena.pop(0)
            if not cadena:
                break
            elif len(cadena[0]) == 0:
                break
            try:
                while not is_cjk(cadena[0][0]) and cadena[0][0] != "～":
                    spanish += cadena.pop(0)
            except:
                None
            self.AddPalabra(japones, pronunciation, spanish)
        self._info["Palabras"] = [i for i in self.GetPalabras().keys()]

    def AddPalabra(self, japones, pronunciation, spanish):
        self._palabras.update({japones: {"Japones": japones, "Pronunciation": pronunciation, "Spanish": spanish}})

    def GetPalabras(self):
        return self._palabras

    def GuardarInfo(self, nombre):
        print("Guardando informacion...")
        GuardarJ(f"Unidad\Info.json",
                 {nombre: self._info},True)

    def GuardarPalabras(self):
        print("Guardando palabras...")
        GuardarJ("Palabras.json", self._palabras, True)

    def GetInfo(self):
        return self._info

    def GetTarjeta(self):
        informacion = self.GetInfo()
        palabras = self.GetPalabras()
        categorias = {"Japones": [], "Pronunciation": [], "Spanish": []}
        formateado = {}
        for j in categorias.keys():
            [categorias[j].extend([i[j]]) for i in list(palabras.values())]
            formateado[j] = MaxLargo(categorias[j])
        largo = MaxLargo([informacion[i] for i in list(informacion.keys()) if i != "Palabras"])
        largo2 = MaxLargo(list(informacion.keys()))
        largo_info = largo + largo2
        largo_palabras = sum(list(formateado.values()))
        if largo_info > largo_palabras:
            largo_palabras = largo_info
            for i in formateado.keys():
                formateado[i] = largo_palabras//3
        else:
            largo = largo_palabras - largo2
            largo2 = largo_palabras - largo
        cuadro = "-" * (largo_palabras +4+formateado["Japones"]//2)
        cadena = cuadro
        cadena += "".join(
            [f'\n|{i.center(largo2+formateado["Japones"]//2+1)}|{informacion[i].center(largo)}|'
             for i in list(informacion.keys()) if i != "Palabras"])
        cadena += f'\n{cuadro}'
        cadena += f'\n|{"Japones".center(formateado["Japones"]+formateado["Japones"]//2)}|{"Pronunciation".center(formateado["Pronunciation"])}|{"Spanish".center(formateado["Spanish"])}|'
        for i in palabras.values():
            cadena += f'\n{cuadro}'
            cadena += f'\n|{i["Japones"].center(formateado["Japones"]+((formateado["Japones"]-len(i["Japones"]))//2))}|{i["Pronunciation"].center(formateado["Pronunciation"])}|{i["Spanish"].center(formateado["Spanish"])}|'
        cadena += f'\n{cuadro}'
        return cadena

    def SaveTarjeta(self, nombre):
        Guardar(
            f"Tarjetas\{nombre}",
            self.GetTarjeta())

    def __str__(self):
        cadena = self.GetInfo()
        del cadena["Palabras"]
        return str(cadena)
