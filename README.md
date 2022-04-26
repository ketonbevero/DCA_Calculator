DCA (Dollar cost average) calculator

A webalkalmazásom célja implementálni egy DCA módszer alapú pénzügyi befektetések követésére szolgáló nyilvántartói rendszert.

Az alkalmazásban lehetőség lesz DCA befektetéseket vezetni. Ehhez meg kell adnunk a vásárolt crypto coin mennyiségét és a vásárlás összegét dollárban/euróban/forintban.

Egy példán levezetve: Pistike bejegyzni hogy vásárolt 2 bitcoint 46000$-os árfolyamon. Ez került neki összesen 92000$-ba.
Pistike 1 hét után ismét vásárol 2 bitcoint, viszont most 45000$-os áron. 
Ez az újabb vásárlás most 90000$-jába került. Pistikének tehát van összesen 4 bitcointja, amit összesen 182 ezer dollárért vásárolt. 
Ekkor az átlagos bitcoin vásárlásának ára 45500$ lett.
Mindegy egyes crypto coinra külön DCA ’bag’-et lehet létrehozni. 
Ebben a bagben lehet nyomonkövetni a vásárlásokat. 
A vásárlásokhoz/eladásokhoz log-file szerűen tartozik dátum, érték és egyéb szükséges mutatók.


A baghez lehet hozzáadni további befektetéseket, egy grafikon fogja nekünk mutatni, hogy az adott bagen hogyan változik dátumról dátumra az átlag árunk. 
A DCA bageket lehet csoportokba rendezni, névvel ellátni, a rendszer automatikusan kiszámolja a csoportokban található bagek értékét, szummázva megjeleníti ennek összértékét. 
Ezek a csoportok lesznek a portfóliók, pl. long-term befektetés portfólió. Egy vagy több DCA bag tartozhat egy portfólióhoz.

A calculatorhoz fog tartozni egy külön felület a profitoknak és egy másik a lossoknak. Ide automatikusan fognak kerülni a lezárt portfóliók. 
Egy portfóliót lezárhat a felhasználó ha megadája az eladási árát a portfólió DCA bagjainek. 
Ha az eladás összege alacsonyabb mint a portfólió átlagos ára, akkor automatikusan a losshoz kerül a portfólió, ellenkező esetben a profit részlegbe. 
Portfólió csak akkor kerül lezárásra, ha az adott portfólióban található összes DCA bag eladásra kerül! Ekkor a rendszer automatikusan zárja, nem kell külön műveletet meghívni rá.
A tranzakciós műveletekhez külön tartozik egy másik, korábban említett log-file szerű felület.  
Itt egy lista szerű felsorolását kell elképzelni, a tranzakciók dátumával csökkenő sorrendben.
Két különböző API fog felelni az árfolyamok lekérésére. 

Az egyik API fogja lekérni az adott FIAT valuta értékét, egy másik pedig a crypto valuta értékét.
Ezek az API-k a lekért adatot továbbítják a portfóliók felé, ahol a valós világpiaci ár szerint jelzi hogy az adott portfólió értéke jelenleg mennyit ér dollárban/euróban/forintban. 
A webalkalmazásba regisztrálni kell, vagy facebookos authentikáción keresztül léphetünk be. A profilhoz alap beállítások tartoznak, például a megjelenítendő valuta. 
A főoldalon egy dashboard jelzi jól összefoglalva az újabb portfóliókat, heti legnagyobb profitot, losst, grafikonnal a heti legnagyobb portfólió növekedést.
