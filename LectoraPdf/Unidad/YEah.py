import json

Texto = open("file.txt", "r").read()
a = json.loads(Texto)
for i in a["products"].values():
    if i["productType"] not in ["CurrencyPack", "SeasonHuntToken"]:
        i["cost"] = {'currencyType': 'Coins', 'value': 0, 'iapType': 'NonConsumable'}
b = []
salida = open("sal.txt", "w")
salida.write(json.dumps(a, separators=(',', ':')))