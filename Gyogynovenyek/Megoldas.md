# Megoldás

# Osztály létrehozása
- Kétféle mód közül bármelyik
  - CTRL + .
  - Adjunk hozzá Itemet
- 5 tulajdonság
  - public get
  - private set 
- 1 konstruktor
  - 1 paraméter (string)
  - például "Acsalapu;levél;6;8"
  - ";" vel vannak elválasztva
  - 4 darab adat --> 5 tulajdonság?
  - átadott, fájlból beolvasott sort:
    - ";" mentén tagoljuk
    - [0] --> Nev
    - [1] --> Resz
    - [2] --> Kezd
    - [3] --> Veg
    - Idotartam --> Számolás
- 5.tulajdonság (időtartam)
    - Konstruktorban számoljuk
    - Számolása: vég-kezdet HA vég > kezdet
    - Vég > Kezdet --> Vég-Kezdet+1
    - Egyébként --> 12-Kezdet+Vég+1
    
## Adatok beolvasása és tárolása
- Listában tároljuk az objektum példányokat
- Olvassuk be:
  - StreamReader (System.IO)
  - while(EndOfStream)
  - Cikluson belül hozzáadunk egy új objektum példányt (Beolvasott sor + paraméter)

## 1. Feladat
- Hány növény van? (lista hossza)
## 2. Feladat
- Milyen gyűjthető részek vannak
  - Foreach Növények
  - Ha a rész nem kulcs --> akkor hozzáadjuk 0-val
- Hány db van ezekből
  - foreach novenyek, ha resz == Key akkor Value ++
## 3. Feladat
- Maximum keresés időtartam alapján
- Növények, amelyek a legtöbb idejig szedhetőek
## 4. Feladat
- Átlag időtartam számítás (Összegzés)