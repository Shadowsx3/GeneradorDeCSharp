import json


def Escribir(texto, identacion):
    file.write("\t" * identacion + f"{texto}\n")


def Aniadir(texto, identacion):
    return "\t" * identacion + f"{texto}\n"


def Cargar_Archivo(nombre):
    a = open(f"{nombre}.json", )
    variable = json.load(a)
    a.close()
    return variable


def Guardar_Archivo(nombre, variable):
    a = open(f"{nombre}.json", )
    file.write(json.dumps(variable))
    a.close()


Configuraciones = Cargar_Archivo("Objeto")
for i in range(len(Configuraciones)):
    Configuraciones[i]["Propiedades"].append({
        "Nombre": "Id",
        "Refiere": "el id",
        "Acceso": "_",
        "Lista": 0,
        "Constructor": True,
        "Tipo": "int",
        "Default": 0
    }, )
file = open(f"Template.cs", "w")
Escribir(
    "using System;\nusing System.IO;\nusing System.Text.Json;\nusing System.Collections.Generic;\nnamespace Template{",
    0)
for Configuracion in Configuraciones:
    Constructores = {}
    Cadena = []
    Escribir(f'#region "{Configuracion["Objeto"]}"', 1)
    Escribir(f"public class {Configuracion['Objeto']}\n\t{{", 1)
    for i in Configuracion['Propiedades']:
        if i['Lista']:
            Escribir(f"private List <{i['Tipo']}> {i['Acceso']}{i['Nombre']} = new List<{i['Tipo']}>();", 2)
            Escribir(
                f"public List <{i['Tipo']}> {i['Nombre']} {{ get => {i['Acceso']}{i['Nombre']}; set => {i['Acceso']}{i['Nombre']} = value; }}",
                2)
        else:
            Escribir(f"private {i['Tipo']} {i['Acceso']}{i['Nombre']};", 2)
            Escribir(
                f"public {i['Tipo']} {i['Nombre']} {{ get => {i['Acceso']}{i['Nombre']}; set => {i['Acceso']}{i['Nombre']} = "
                f"value; }}",
                2)
            if i['Constructor']:
                Constructores.update(
                    {f"{i['Tipo']} {i['Nombre'].lower()}": [f"this.{i['Nombre']} = {i['Nombre'].lower()};",
                                                            f"this.{i['Nombre']} = {i['Default']};"]})
                Cadena.append(f"{i['Nombre'].title()}: {{this.{i['Nombre']}}}\\n")
    atributos = ", ".join(list(Constructores.keys()))
    print(atributos)
    Escribir(f"public {Configuracion['Objeto']}({atributos}){{", 2)
    for i in Constructores.keys():
        Escribir(f"{Constructores[i][0]}", 3)
    Escribir(f"}}", 2)
    Escribir(f"public {Configuracion['Objeto']}(){{", 2)
    for i in Constructores.keys():
        Escribir(f"{Constructores[i][1]}".replace("'", '"'), 3)
    Escribir(f"}}", 2)
    Escribir("public override string ToString(){", 2)
    Escribir("string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });", 3)
    Escribir('string espacio = "----------------------------------------------------------------";', 3)
    Escribir('json = $"{espacio}\\n{json}\\n{espacio}";', 3)
    Escribir(f'return json;', 3)
    Escribir(f"}}", 2)
    Escribir(f"}}", 1)
    Escribir(f'#endregion', 1)
Escribir(f'#region "Programa"', 1)
Escribir(f"public class Programa\n\t{{", 1)
Valores = Cargar_Archivo("Tipos")
Editar = Cargar_Archivo("Modify")
for tipo in Editar.keys():
    Escribir(f"static {tipo} Solicitar{tipo.title()}(string mensaje){{", 2)
    Escribir(f"Console.WriteLine(mensaje);", 2)
    Escribir("string entrada = Console.ReadLine();", 2)
    if Editar[tipo]['Conversor'] == '':
        Escribir(f"return entrada;", 2)
    else:
        Escribir(f"try{{", 2)
        Escribir(f"return {Editar[tipo]['Conversor']}(entrada);", 3)
        Escribir("}catch{", 2)
        Escribir(f'Console.WriteLine("Dato erroneo");', 3)
        Escribir(f"return Solicitar{tipo.title()}(mensaje);}}", 3)
    Escribir(f"}}", 2)
Menus = {}
for Configuracion in Configuraciones:
    Escribir(
        f"static void Add{Configuracion['Objeto']}es(List<{Configuracion['Objeto']}> {Configuracion['Objeto'].lower()}s){{",
        2)
    Escribir('string j = "";', 3)
    Escribir('while (j == ""){', 3)
    Escribir(f'Ingreso{Configuracion["Objeto"]}({Configuracion["Objeto"].lower()}s);', 4)
    Escribir('Console.WriteLine("Presione enter para continuar agregando\\n");', 4)
    Escribir(f'j = Console.ReadLine();', 4)
    Escribir(f'}}', 4)
    Escribir("}", 2)
    Escribir(
        f"static void GuardarDatos{Configuracion['Objeto']}(List <{Configuracion['Objeto']}> {Configuracion['Objeto'].lower()}){{",
        2)
    Escribir(f'string fileName = "BaseDeDatos{Configuracion["Objeto"]}.json";', 3)
    Escribir(f'string jsonString = JsonSerializer.Serialize({Configuracion["Objeto"].lower()});', 3)
    Escribir('File.WriteAllTextAsync(fileName, jsonString);}', 3)
    Escribir(
        f"static List<{Configuracion['Objeto']}> CargarDatos{Configuracion['Objeto']}(){{",
        2)
    Escribir(f'string fileName = "BaseDeDatos{Configuracion["Objeto"]}.json";', 3)
    Escribir('string jsonString = File.ReadAllText(fileName);', 3)
    Escribir(
        f"List <{Configuracion['Objeto']}> {Configuracion['Objeto'].lower()} = JsonSerializer.Deserialize<List<{Configuracion['Objeto']}>>(jsonString);",
        3)
    Escribir(f'return {Configuracion["Objeto"].lower()};}}', 3)
    Escribir(
        f"static void BorrarIndice{Configuracion['Objeto']}(List <{Configuracion['Objeto']}> {Configuracion['Objeto'].lower()}, int id){{",
        2)
    Escribir(f"try{{", 3)
    Escribir("int j = 0;", 4)
    Escribir(
        f"foreach({Configuracion['Objeto']} {Configuracion['Objeto'][0]} in {Configuracion['Objeto'].lower()}){{",
        4)
    Escribir(f"if ({Configuracion['Objeto'][0]}.Id == id){{", 5)
    Escribir(f"{Configuracion['Objeto'].lower()}.RemoveAt(j);", 6)
    Escribir("}", 5)
    Escribir("j += 1;", 4)
    Escribir("}", 4)
    Escribir("}catch{", 3)
    Escribir(f'Console.WriteLine("Id erroneo");', 4)
    Escribir(f"}}}}", 3)
    Escribir(f'#region "Filtro{Configuracion["Objeto"]}"', 2)
    imprimir2 = Aniadir(
        f'static void Imprimir{Configuracion["Objeto"]}(List <{Configuracion["Objeto"]}> {Configuracion["Objeto"].lower()}, int id){{',
        2)
    imprimir2 += Aniadir(f"try{{", 3)
    imprimir2 += Aniadir(
        f"foreach({Configuracion['Objeto']} {Configuracion['Objeto'][0]} in {Configuracion['Objeto'].lower()}){{",
        4)
    imprimir2 += Aniadir(f"if ({Configuracion['Objeto'][0]}.Id == id){{", 5)
    imprimir2 += Aniadir(f"Console.WriteLine({Configuracion['Objeto'].lower()}[id]);", 6)
    imprimir2 += Aniadir("}", 5)
    imprimir2 += Aniadir("}", 4)
    imprimir2 += Aniadir("}catch{", 3)
    imprimir2 += Aniadir(f'Console.WriteLine("Id erroneo");', 4)
    imprimir2 += Aniadir(f"}}", 3)
    imprimir2 += Aniadir("}", 2)
    imprimir = Aniadir(
        f'static void Imprimir{Configuracion["Objeto"]}(List <{Configuracion["Objeto"]}> {Configuracion["Objeto"].lower()}){{',
        2)
    imprimir += Aniadir("int j = 0;", 3)
    imprimir += Aniadir(
        f"foreach({Configuracion['Objeto']} {Configuracion['Objeto'][0]} in {Configuracion['Objeto'].lower()}){{",
        3)
    imprimir += Aniadir(f'Console.WriteLine($"{Configuracion["Objeto"]} Nro {{j}}");', 4)
    imprimir += Aniadir(f"Console.WriteLine({Configuracion['Objeto'][0]});", 4)
    imprimir += Aniadir("j += 1;", 4)
    imprimir += Aniadir("}", 3)
    imprimir += Aniadir("}", 2)
    Escribir(imprimir, 0)
    Escribir(imprimir2, 0)
    ingreso = Aniadir(
        f'static void Ingreso{Configuracion["Objeto"]}(List <{Configuracion["Objeto"]}> {Configuracion["Objeto"].lower()}){{',
        2)
    ingreso += Aniadir(
        f'{Configuracion["Objeto"]} {Configuracion["Objeto"].lower()}s = new {Configuracion["Objeto"]}();', 3)
    ingreso += Aniadir(f'Console.WriteLine("Ingreso de {Configuracion["Objeto"]}");', 3)
    ingreso += Aniadir('Console.WriteLine("----------------------------------------------------------------");', 3)
    Menus[Configuracion["Objeto"]] = [Aniadir(f'public static void BuscarPor{Configuracion["Objeto"]}(){{\n'
                                              f'\t\t\tConsole.WriteLine("Menu: {Configuracion["Objeto"]}");\n'
                                              f'\t\t\tConsole.WriteLine("Elige una opcion:");', 2)]
    for i in Configuracion['Propiedades']:
        NombreMenu = f'{Configuracion["Objeto"]}{i["Nombre"]}'
        Menus[Configuracion["Objeto"]].append(
            f'\t\t\tConsole.WriteLine("{len(Menus[Configuracion["Objeto"]])-1}) {i["Nombre"]}");')
        Menus[NombreMenu] = [
            Aniadir(f'public static void Buscar{Configuracion["Objeto"]}{i["Nombre"]}(){{\n'
                    f'\t\t\tConsole.WriteLine("Menu: {Configuracion["Objeto"]}{i["Nombre"]}");\n'
                    f'\t\t\tConsole.WriteLine("Elige una opcion:");', 2)]
        """private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Exit");
 
            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    RemoveWhitespace();
                case "3":
                    return false;
                default:
                    return true;
            }"""
        Escribir(
            f"static void Editar{i['Nombre']}{Configuracion['Objeto']}(List <{Configuracion['Objeto']}> {Configuracion['Objeto'].lower()}, int id){{",
            2)
        Escribir(f"try{{", 3)
        Escribir(
            f"foreach({Configuracion['Objeto']} {Configuracion['Objeto'][0]} in {Configuracion['Objeto'].lower()}){{",
            4)
        Escribir(f"if ({Configuracion['Objeto'][0]}.Id == id){{", 5)
        Escribir('Console.WriteLine("Actual");', 6)
        Escribir(f'Console.WriteLine({Configuracion["Objeto"][0]});', 6)
        Escribir(f"Set{i['Nombre']}({Configuracion['Objeto'][0]});", 6)
        Escribir("}", 5)
        Escribir("}", 4)
        Escribir("}catch{", 3)
        Escribir(f'Console.WriteLine("Id erroneo");', 4)
        Escribir(f"}}}}", 3)

        if i["Lista"] > 0:
            Escribir(f"static void Set{i['Nombre']}({Configuracion['Objeto']} {Configuracion['Objeto'].lower()}){{", 2)
            Escribir(
                f'List<{i["Tipo"]}> {i["Nombre"]}s = new List<{i["Tipo"]}>();',
                3)
            for m in range(i["Lista"]):
                Escribir(f'{i["Nombre"]}s.Add(Solicitar{i["Tipo"].title()}("Ingrese {i["Refiere"]}\\n"));',
                         3)
            Escribir(
                f'{Configuracion["Objeto"].lower()}.{i["Nombre"]} = {i["Nombre"]}s;',
                3)
            Escribir("}", 2)
        if i["Lista"] < 0:
            Escribir(f"static void Set{i['Nombre']}({Configuracion['Objeto']} {Configuracion['Objeto'].lower()}){{", 2)
            Escribir(
                f'List<{i["Tipo"]}> {i["Nombre"]}s = new List<{i["Tipo"]}>();',
                3)
            Escribir('string j = "";', 3)
            Escribir('while (j == ""){', 3)
            if i["Tipo"] in [m["Objeto"] for m in Configuraciones]:
                Escribir(f'Ingreso{i["Tipo"]}({i["Nombre"]}s);', 4)
            else:
                Escribir(f'{i["Nombre"]}s.Add(Solicitar{i["Tipo"].title()}("Ingrese {i["Refiere"]}\\n"));', 4)
            Escribir(f'j = Console.ReadLine();', 4)
            Escribir(f'}}', 4)
            Escribir(
                f'{Configuracion["Objeto"].lower()}.{i["Nombre"]} = {i["Nombre"]}s;',
                3)
            Escribir("}", 2)
        ingreso += Aniadir(f'Set{i["Nombre"]}({Configuracion["Objeto"].lower()}s);', 3)
        if i["Lista"] == 0 and i["Tipo"] in Valores.keys():
            Escribir(f"static void Set{i['Nombre']}({Configuracion['Objeto']} {Configuracion['Objeto'].lower()}){{", 2)
            Escribir(
                f'{Configuracion["Objeto"].lower()}.{i["Nombre"]} = Solicitar{i["Tipo"].title()}("Ingrese {i["Refiere"]}\\n");',
                3)
            Escribir("}", 2)
            for j in Valores[i["Tipo"]]:
                Menus[NombreMenu].append(
                f'\t\t\tConsole.WriteLine("{len(Menus[NombreMenu]) - 1}) {j["Nombre"]}{i["Nombre"]}");')
                Escribir(
                    f"List<{Configuracion['Objeto']}> {j['Nombre']}{i['Nombre']}(List <{Configuracion['Objeto']}> {Configuracion['Objeto'].lower()}){{",
                    2)
                Escribir(
                    f'{i["Tipo"]} valor = Solicitar{i["Tipo"].title()}("Ingrese un valor");',
                    3)
                Escribir(
                    f'bool imprimir = true;',
                    3)
                Escribir(
                    f"List<{Configuracion['Objeto']}> {Configuracion['Objeto'].upper()} = new List<{Configuracion['Objeto']}>();",
                    3)
                Escribir(
                    f"foreach({Configuracion['Objeto']} {Configuracion['Objeto'][0]} in {Configuracion['Objeto'].lower()}){{",
                    3)
                Escribir(f"if ({Configuracion['Objeto'][0]}.{i['Nombre']} {j['Comparador']} valor){{", 4)
                Escribir(f"{Configuracion['Objeto'].upper()}.Add({Configuracion['Objeto'][0]});", 5)
                Escribir(f"}}", 4)
                Escribir(f"}}", 3)
                Escribir(f"if (imprimir){{", 3)
                Escribir(f"Imprimir{Configuracion['Objeto']}({Configuracion['Objeto'].upper()});", 4)
                Escribir(f"}}", 3)
                Escribir(f"return {Configuracion['Objeto'].upper()};", 3)
                Escribir(f"}}", 2)
    ingreso += Aniadir(f'{Configuracion["Objeto"].lower()}.Add({Configuracion["Objeto"].lower()}s);', 3)
    ingreso += Aniadir('Console.WriteLine("----------------------------------------------------------------");\n\t\t}',
                       3)
    Escribir(ingreso, 0)
    Escribir(f'#endregion', 2)
funciones = {}
for objeto in Menus.keys():
    Escribir(Menus[objeto][0], 0)
    nombre = Menus[objeto][0].split(" ")[3].replace('{\n\t\t\tConsole.WriteLine("Menu:',"")
    funciones[nombre] = []
    for linea in range(1, len(Menus[objeto])):
        Escribir(Menus[objeto][linea], 0)
        print(nombre[:])
        nombrefun = Menus[objeto][linea].split(" ")[1].replace('");', "") + "()"
        if nombre[:].count("BuscarPor") > 0:
            nombrefun = nombre[:-2] + nombrefun
        funciones[nombre].append(nombrefun)
    exit = len(funciones[nombre])
    Escribir(f'Console.WriteLine("{exit}) Exit");', 3)
    Escribir("switch (Console.ReadLine()){",3)
    for fun in range(len(funciones[nombre])):
        Escribir(f'case "{fun}":', 4)
        Escribir(f'{funciones[nombre][fun]};', 5)
        Escribir(f'break;', 5)
    Escribir(f'default:', 4)
    Escribir(f'return;', 5)
    Escribir("}", 3)
    Escribir("}", 2)
print(funciones)
Escribir(f"}}", 1)
Escribir(f'#endregion', 1)
Escribir(f"}}", 0)
