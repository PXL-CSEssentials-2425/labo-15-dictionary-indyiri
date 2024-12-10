# Labo 15 - Dictionary

# Klassement Beheer Systeem - Console Applicatie

Dit project demonstreert hoe je een `Dictionary` kunt gebruiken in C#. Het programma stelt je in staat om een klassement te beheren door deelnemers en hun scores op te slaan, op te halen, te wijzigen, en te analyseren.

## Functionaliteiten

1. **Toon het klassement**  
   Bekijk een overzicht van alle deelnemers en hun scores.

2. **Zoek de score van een deelnemer**  
   Voer een naam in om de bijbehorende score te bekijken.

3. **Pas de score van een deelnemer aan of voeg een nieuwe deelnemer toe**  
   Werk de score van een bestaande deelnemer bij of voeg een nieuwe deelnemer toe.

4. **Toon de gemiddelde score**  
   Bereken en toon de gemiddelde score van alle deelnemers.

5. **Toon de deelnemer met de hoogste score**  
   Bekijk wie de hoogste score in het klassement heeft.

6. **Stop het programma**  
   Beëindig het programma.

---

## Voorbeelduitvoer

### Menu
```plaintext
Welkom bij het Klassement Beheer Systeem!
Kies een optie uit het menu:

1. Toon het klassement
2. Zoek de score van een deelnemer
3. Pas de score van een deelnemer aan of voeg een nieuwe deelnemer toe
4. Toon de gemiddelde score
5. Toon de deelnemer met de hoogste score
6. Stop het programma

Maak uw keuze: _
```
### 1. Toon het klassement
```plaintext
Klassement:
- Emma: 18 punten
- Liam: 19 punten
- Noah: 17 punten
- Olivia: 20 punten
```
### 2. Zoek de score van een deelnemer
```plaintext
Geef de naam van een deelnemer: Olivia
Olivia heeft 20 punten.

(of als de deelnemer niet bestaat)

Geef de naam van een deelnemer: Anna
Anna staat niet in het klassement.
```
### 3. Pas de score van een deelnemer aan of voeg een nieuwe deelnemer toe
```plaintext
Geef de naam van een deelnemer: Liam
Geef de nieuwe score: 21
De score van Liam is bijgewerkt naar 21 punten.

(of als de deelnemer nog niet bestaat)

Geef de naam van een deelnemer: Anna
Geef de nieuwe score: 16
Anna is toegevoegd aan het klassement met 16 punten.
```
### 4. Toon de gemiddelde score
```plaintext
De gemiddelde score van alle deelnemers is: 18,5 punten.
```
### 5. Toon de deelnemer met de hoogste score
```plaintext
De deelnemer met de hoogste score is Olivia met 20 punten.
```
### 6. Stop het programma
```plaintext
Bedankt voor het gebruiken van het Klassement Beheer Systeem. Tot ziens!
```
