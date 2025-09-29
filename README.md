# Reinforcement Learning Car Simulation 🚗🤖

This project demonstrates a **Reinforcement Learning agent** built in **Unity** using custom **Neural Networks** and **Genetic Algorithms**.  
The goal: evolve a self-driving car agent that learns to navigate efficiently.

---

## 🔑 Features
- **Custom Neural Network** in Unity (C#) with tunable hidden layers (see `NNet.cs`).
- **Genetic Algorithm Framework** (see `GeneticManager.cs`):
  - Selection, crossover, and mutation operations.
  - Fitness-based repopulation loop to evolve agents.  
- **Simulation**: Cars drive in Unity environment, evolving every generation.  
- **Results**: Top-performing agent achieved by **Generation 2, Genome 25**.  

---

## 📂 Project Structure
- `GeneticManager.cs` → Handles population management, fitness evaluation, and reproduction.
- `NNet.cs` → Implements feed-forward neural network with customizable layers.  
- Unity Scene → Contains car prefab and track for training.  

---

## 🛠 Tech Stack
- **Unity (C#)** for simulation
- **Genetic Algorithms** for evolution
- **Custom Neural Networks** for decision-making  

---

## 📊 Visual Demo
![Car Simulation Demo](https://via.placeholder.com/600x300.png?text=Car+RL+Demo)

---

## 🚀 How to Run
1. Clone repo and open in Unity.  
2. Attach `NNet.cs` to car prefab, and `GeneticManager.cs` to scene manager.  
3. Hit Play → Watch cars evolve across generations.  

---

## 📈 Key Takeaways
- Demonstrates **neuroevolution** techniques in Unity.  
- Reinforcement learning without backpropagation, using **genetic optimization**.  
- Framework can be extended to more complex environments.  

---

## 👤 Author
Pradyumn K. Pottapatri  
📍 Data Scientist | ML Engineer | NLP & Reinforcement Learning  
[LinkedIn](https://www.linkedin.com/) | [GitHub](https://github.com/ner-aim)
