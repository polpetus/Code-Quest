# ⚔️ CodeQuest

Un joc de consola fet en **C#** on et converteixes en un mag aprenent que ha d'entrenar, vèncer un drac i saquejar una mina màgica. 🧙‍♂️🐉💰

---

## 🎮 Com es juga

Quan executes el programa apareix aquest menú:

```
===== MAIN MENU - CODEQUEST =====
1. Train your wizard
2. Check the dungeon
3. Loot the mine
0. Exit game
```

🔒 Els capítols s'han de jugar **en ordre**: el 2 es desbloqueja en acabar l'1, i el 3 en obrir totes les portes del 2.

---

## 🧙 Capítol 1: El camí del mag aprenent

Has entrat a l'Acadèmia d'Arcanistes. Posa nom al teu mag i entrena'l durant **5 dies** ⌛

- Cada dia medita unes hores i guanya entre **1 i 10 punts de poder** 💪
- Cada **10 punts** puja de nivell 🎉
- Al final, segons el poder total, obtens un rang:

| Poder total | Rang |
|:-----------:|------|
| < 20 | 💀 Raoden el Elantrí |
| 20 - 29 | 🤡 Zyn el Buguejat |
| 30 - 34 | 🫡 Arka Nullpointer |
| 35 - 39 | 🔥 Elarion de les Brases |
| 40 o més | 🧙 ITB-Wizard el Gris |

---

## 🐉 Capítol 2: El calabós del Drac RAMón el Poderós

Per aconseguir el tresor has d'obrir **3 portes** 🚪

- Cada porta té un **codi secret aleatori entre 1 i 5** 🔑
- Tens **3 intents** per porta
- Si falles, el drac t'expulsa del servidor 🐲❌
- Si obres les 3 portes, et quedes amb el tresor del drac 💎

---

## 💰 Capítol 3: Saquejar el botí

Sota el cau del drac hi ha una mina plena de bitcoins màgics ⛏️

- Pots excavar només **5 vegades**
- Cada cop trobes entre **5 i 50 bits** 🪙... o potser res (**20 %** de probabilitat)
- Si el total supera els **200 bits**, desbloqueges la **GPU d'or** ⚜️
- Si no, la teva targeta màgica continua sent integrada 🪵

---

## 🌿 Branques de Git

- `chapter/trainwizard`
- `chapter/checkdungeon`
- `chapter/lootthemine`
