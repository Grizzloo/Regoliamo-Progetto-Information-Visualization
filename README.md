**RegoliAMO** è un gioco educativo in Realtà Aumentata pensato per aiutare i bambini ad apprendere il concetto del **Muro del 10** attraverso l’uso virtuale dei regoli matematici.

Il progetto nasce per rendere l’apprendimento della matematica **intuitivo, interattivo e divertente**, sfruttando tecnologie AR moderne come **Unity**, **Vuforia** e modelli 3D dinamici.

---

## 🎯 Obiettivo Didattico

L’applicazione ha lo scopo di:

- migliorare la comprensione dei numeri e della somma fino al 10  
- aiutare i bambini a visualizzare i regoli in modo interattivo  
- stimolare problem solving e logica  
- fornire feedback immediati e un’esperienza positiva  

Il concetto del **Muro del 10** viene appreso in maniera naturale grazie all’interazione diretta con i regoli virtuali.

---

## 🧠 Idea del Progetto

Nei primi anni di vita, la matematica è fondamentale per lo sviluppo cognitivo.  
RegoliAMO propone un approccio innovativo:

> **Scansiona → Interagisci → Comprendi → Costruisci il Muro del 10**

La valigetta dei regoli fisici viene riconosciuta in AR e trasformata in un ambiente virtuale dinamico.

---

## 🛠️ Tecnologie Utilizzate

- **Unity**
- **Vuforia Engine** (riconoscimento target 2D)
- **C#**
- **ARCore / ARKit**
- Modelli 3D dei regoli
- Unity UI / Animation System

---

## 🔍 Come Funziona

### 📷 Riconoscimento del Target
Viene utilizzato il riconoscimento 2D tramite **Vuforia** per identificare la valigetta contenente i regoli e posizionare correttamente gli elementi virtuali.

### 🧩 Costruzione del Muro del 10
L’utente può selezionare i regoli AR per:

- aggiungerli alla somma  
- costruire il muro  
- ricevere colori e feedback dinamici  

### 🎨 Feedback immediato
- colori dinamici del muro  
- animazioni dei regoli spostati  
- warning se la somma supera 10  
- pagine di vittoria / errore  

---

## 🕹️ Scene dell’Applicazione

### **1️⃣ StartMenu**
Schermata iniziale dove il bambino sceglie:
- **Gioca**
- **Gioca con aiuti**

---

### **2️⃣ GameScene**
La scena principale di gioco include:
- struttura del muro da completare  
- regoli cliccabili  
- somma aggiornata dinamicamente  
- pulsanti: *elimina*, *conferma*, *ricomincia*, *esci*  
- animazione del regolo selezionato tramite `MoveTowards`  
- warning in caso di somma > 10  

---

### **3️⃣ GameSceneAiuti**
Come la GameScene, ma con supporto intelligente tramite:

#### 🧠 **RegoloManager**
- controlla costantemente la somma  
- disattiva automaticamente i regoli che porterebbero a errore  
- previene sommatorie > 10  

---

### **4️⃣ RispostaEsatta**
Se il bambino raggiunge 10:
- fuochi d’artificio  
- musica festosa  
- messaggio motivazionale  

---

### **5️⃣ RispostaSbagliata**
Se il bambino non raggiunge 10:
- vignetta con messaggio di errore  
- scelta: riprova senza aiuti / riprova con aiuti  

