import codecs
import json
from os.path import isfile

def Leer(path):
    a = codecs.open(f'{path}.text', 'r+',
                    encoding='utf-8')
    return a.read()


def cargar(path):
    a = codecs.open(f'{path}.json', 'r+',
                    encoding='utf-8')
    try:
        variable = json.load(a)
    except:
        variable = {}
    a.close()
    return variable


def Guardar(path, cadena, sobreescribir=False):
    if sobreescribir and isfile(path):
        a = codecs.open(f'{path}', 'r+',
                        encoding='utf-8')
        try:
            variable = json.load(a)
        except:
            variable = {}
        a.close()
        nuevo = json.loads(cadena)
        variable.update(nuevo)
        cadena = json.dumps(variable, indent=4, ensure_ascii=False)
    f = codecs.open(f'{path}', 'w+',
                    encoding='utf-8')
    f.write(cadena)
    f.close()


def GuardarJ(path, cadena, sobreescribir=False):
    if sobreescribir and isfile(path):
        a = codecs.open(f'{path}', 'r+',
                        encoding='utf-8')
        try:
            variable = json.load(a)
        except:
            variable = {}
        a.close()
        variable.update(cadena)
        cadena = variable
    f = codecs.open(f'{path}', 'w+',
                    encoding='utf-8')
    f.write(json.dumps(cadena, indent=4, ensure_ascii=False))
    f.close()


ranges = [
    {"from": ord(u"\u3300"), "to": ord(u"\u33ff")},  # compatibility ideographs
    {"from": ord(u"\ufe30"), "to": ord(u"\ufe4f")},  # compatibility ideographs
    {"from": ord(u"\uf900"), "to": ord(u"\ufaff")},  # compatibility ideographs
    {"from": ord(u"\U0002F800"), "to": ord(u"\U0002fa1f")},  # compatibility ideographs
    {'from': ord(u'\u3040'), 'to': ord(u'\u309f')},  # Japanese Hiragana
    {"from": ord(u"\u30a0"), "to": ord(u"\u30ff")},  # Japanese Katakana
    {"from": ord(u"\u2e80"), "to": ord(u"\u2eff")},  # cjk radicals supplement
    {"from": ord(u"\u4e00"), "to": ord(u"\u9fff")},
    {"from": ord(u"\u3400"), "to": ord(u"\u4dbf")},
    {"from": ord(u"\U00020000"), "to": ord(u"\U0002a6df")},
    {"from": ord(u"\U0002a700"), "to": ord(u"\U0002b73f")},
    {"from": ord(u"\U0002b740"), "to": ord(u"\U0002b81f")},
    {"from": ord(u"\U0002b820"), "to": ord(u"\U0002ceaf")}  # included as of Unicode 8.0
]


def is_cjk(char):
    if char == "～":
        return True
    return any([range["from"] <= ord(char) <= range["to"] for range in ranges])


def Reemplazo(cadena, nombre):
    cadena = cadena.replace(nombre, "").strip()
    return cadena


def MaxLargo(lista):
    return len(max(lista, key=len))


def RemoverNumPag(texto):
    return "\n".join(texto.split("\n")[:-1]) + "\n"
