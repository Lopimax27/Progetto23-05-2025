# 🚛 Gestione Dipendenti - Compagnia di Trasporti (C#)

## 📝 Descrizione

Questo progetto è un'applicazione console scritta in C# per la gestione dei dipendenti di una compagnia di trasporti. I dipendenti possono essere **autisti**, **meccanici** o **operatori di centrale**. Il programma dimostra l'utilizzo dei concetti di **incapsulamento**, **ereditarietà** e **polimorfismo**.

---

## 📋 Requisiti del Progetto

### 🧱 Classe Base: `Dipendente`

- 🔒 **Campi privati**:
  - `nome` (string)
  - `eta` (int)
- 🌐 **Proprietà pubbliche**:
  - `Nome` (get, set)
  - `Eta` (get, set) → accetta solo valori ≥ 18
- 🧠 **Metodo virtuale**:
  - `EseguiCompito()` stampa: `"Compito generico del dipendente."`

### 🧬 Classi Derivate

#### 🚗 `Autista`
- ➕ Campo aggiuntivo: `Patente` (string)
- 🔁 Override di `EseguiCompito()` → `"Guida il veicolo con patente X"`

#### 🔧 `Meccanico`
- ➕ Campo aggiuntivo: `Specializzazione` (string)
- 🔁 Override di `EseguiCompito()` → `"Ripara mezzi specializzati in: X"`

#### 🖥️ `OperatoreCentrale`
- ➕ Campo aggiuntivo: `Turno` (string, "giorno" o "notte")
- 🔁 Override di `EseguiCompito()` → `"Gestisce le comunicazioni in turno: X"`

---

## 🔧 Funzionalità del Main

- 📑 Utilizza `List<Dipendente>` per contenere tutti i dipendenti.
- 📜 Menu per:
  - ➕ Aggiungere un nuovo `Autista`, `Meccanico` o `OperatoreCentrale`
  - 👁️ Visualizzare tutti i dipendenti con nome, tipo e dati specifici
  - 🧠 Chiamare `EseguiCompito()` su tutti (**polimorfismo**)
  - ❌ Uscire dal programma

---

## ⭐ Extra

- 👤 Gestione di una **classe utente** che può utilizzare il sistema e ✍️ **salvare tutte le azioni compiute** in una lista (storico delle operazioni).

---

## ▶️ Esecuzione

Compilare ed eseguire il file `.cs` tramite Visual Studio o tramite terminale con il .NET SDK:

```bash
dotnet build
dotnet run
