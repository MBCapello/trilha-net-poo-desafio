# 📱 Testa Fácil - Desafio DIO .NET POO

Sistema de demonstração de celulares orientado a objetos, desenvolvido como desafio do módulo de Programação Orientada a Objetos da DIO.

---

## 📋 Sobre o Projeto

Este projeto simula um sistema de celulares, permitindo criar e testar aparelhos das marcas **Nokia** e **iPhone**. O objetivo é demonstrar o uso de herança, classes abstratas e polimorfismo em C#, seguindo o diagrama proposto no desafio.

---

## 🏗️ Estrutura das Classes

- **Smartphone (abstrata):**

  - Propriedades: `Numero`, `Modelo`, `Imei`, `Memoria`
  - Métodos: `Ligar()`, `ReceberLigacao()`, `InstalarAplicativo(string nomeApp)` (abstrato)

- **Nokia** e **Iphone**:
  - Herdam de `Smartphone`
  - Implementam o método `InstalarAplicativo` de forma específica para cada marca

---

## 🚀 Como Executar

1. Clone este repositório
2. Abra a pasta no VS Code ou outro editor de sua preferência
3. Execute no terminal:
   ```bash
   dotnet run
   ```
