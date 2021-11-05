Texto = open('code.cs', 'r').read()
Salida = {}
Tirar = ""
for i in Texto.split('\n'):
    linea = i.strip()
    if linea.startswith("public class "):
        Tirar = i.strip().replace("public class ", "")
        Salida[Tirar] = [i.rstrip().replace("class ", "interface I"), "{"]
    elif linea.endswith(")"):
        agrega = linea.split("(")
        agregar = agrega[0].split(" ")
        largo = len(agregar) - 1
        Salida[Tirar].append(agregar[largo - 1] + " " + agregar[largo] + "(" + agrega[1] + ";")
f = open("codeN.cs", "w")
tabs = 0
for i in Salida.keys():
    tabs = Salida[i][0].count("    ") + 1
    print(tabs)
    for j in Salida[i]:
        f.write(j + "\n" + tabs * "\t")
    f.write("}")
