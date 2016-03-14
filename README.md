#**Hotelski smještaj**
<br />
<br /> Članovi tima:
<br /> 1. Merima Komić 
<br /> 2. Ismar Kubat
<br /> 3. Medina Kulić
<br /> 4. Amina Mahmutović
 
## **Opis teme**

Izabrana tema „Hotelski smještaj“ predstavlja projektno rješenje koje kao korisnika uzima hotelsku grupaciju. 
Sama tema hotelski smještaj bazirana je na interakciji korisnika sistema 
(koji je u ovom slučaju izabrana grupacija hotela) i njihovih potencijalnih gostiju.
Osim toga, tema pokriva i dio samog rada i funkcionisanja hotela koji se odnosi na održavanje dostupnosti soba, njihovo saniranje kao i regularnu isplatu 
od strane gostiju hotela.

##**Procesi:**

###**1. Rezervacija i iznajmljivanje sobe**
Gostu je omogućeno da, nakon pregleda i ustanovljene tražene lokacije i 
zahtjeva po pitanju soba, provjerava dostupnost soba. Pretraga je vezana na bazu podataka koja sadrži hotele i 
smjernice na sobe (koje mogu biti jednokrevetne, dvokrevetne, jednokrevetne bračne i apartmani), a vrši se 
unosom lokacije i vrste sobe. Ukoliko je pretraga uspješna, odnosno ukoliko postoji soba unutar grupacije koja 
zadovoljava uslove gosta, gostu se ponudi rezervacija sobe.Samo iznajmljivanje sobe se vrši dodjelom ključa, te korisničke šifre gostu koji je već 
rezervisao sobu i to isključivo na prvi dan rezervacije i ukoliko je soba spremna za izdavanje.

###**2.Evidencija i registracija gostiju hotela**
Administrator sistema dobija informacije potrebne za evidentiranje gosta prilikom njegovog rezervisanja ili iznajmljivanja sobe. 
Administrator kao povratnu informaciju šalje korisničku šifru, koju gost moze koristiti za vrijeme boravka u hotelu kako bi imao pristup aplikaciji koja olakšava 
traženje usluga ili informacija od strane hotela.

###**3.Ocjenjivanje hotela**
Unutar aplikacije kojoj imaju pristup gosti, postoji dio za ocjenjivanje hotela.
Bodovi se obračunavaju i uvrštavaju u konačnu prosječnu ocjenu hotela. (od strane gostiju)

###**4.Provjera ispravnosti sobe**
Prilikom napuštanja hotela, gost je dužan sačekati provjeru ispravnosti sobe. U slučaju određene štete, gost je dužan isplatiti određenu nadoknadu, 
koju procjenjuje osoblje hotela zaduženo za održavanje sobe.

###**5.Ispunjavanje zahtjeva od strane gosta**
Potrebne informacije, gost hotela dobiva pomoću aplikacije. Također, putem aplikacije gost hotela može izvršiti određene narudžbe. 
Isporuku do sobe hotela vrši adekvatno hotelsko osoblje.

###**6.Obračun troška**
U obračun troška ulazi broj dana provedenih u hotelu, posebni zahtjevi gosta upućenih putem aplikacije kao i eventualne stete. Prilikom napuštanja hotela, gost 
dobija ukupan račun te je dužan odmah da ga isplati. Njegov korisnički račun se gasi/blokira i na taj način onemogućava pristup aplikaciji hotela 
koja je određena samo za trenutne goste.

##**Funkcionalnosti:**

1. Mogucnost online rezervacije
2. Mogucnost trezenja informacija i usluga putem aplikacije
3. Mogucnost ocjenjivanja hotela
4. Mogucnost kontrole hotela od strane administratora
5. Mogucnost adekvatne i direktne regulacije troskova
6. Mogucnost automatskog poziva vanjskog saradnika u slučaju kvara ili nedostataka

##**Akteri:**
1. Potencijalni gost hotela - osoba koja putem aplikacije bira i rezervise sobu.
2. Gost hotela - osoba koja je već iznajmila sobu te ima korisničku šifru za pristup hotelskoj aplikaciji.
3. Recepcionar - osoba koja predaje ključ i šifru prilikom iznajmljivanja sobe. Također, ta osoba daje račun gostu prilikom njegovog napuštanja hotela.
4. Hotelsko osoblje -osobe zadužene za održavanje soba kao i ispunjavanje zahtjeva gosta.
5. Administrator - vrsi upravljanje sistemom

