# Space Shooter – Object Pooling Design Pattern

As part of **Outscal’s Design Patterns module**, this project explores the **Object Pooling Design Pattern** by implementing it in a classic **Space Shooter** game.  
The main focus was on **performance optimization** through reusing frequently spawned and destroyed objects like bullets and enemies.

---

## Gameplay
Click on following image to view gameplay. 
[![Image](https://github.com/user-attachments/assets/a4a06e29-bdd7-4023-9159-8366093ad601)](https://drive.google.com/file/d/1BKmPB_qAGTnqTP6d_u1YTaq798-aRY5i/view?usp=sharing)

---

## What I Learned

-  Practical application of the **Object Pooling Pattern** in real-time gameplay.
-  How to **reuse game objects** (e.g., bullets, enemies, power-ups) to avoid unnecessary instantiation/destruction.
-  Performance benefits of pooling: reduced GC overhead and smoother gameplay.
-  Extended the system into a **Generic Object Pool** to handle multiple object types from a single manager.

---

## Gameplay Overview

-  The player controls a spaceship that can shoot bullets.
-  Enemies spawn and move toward the player.
-  On collision or destruction, bullets and enemies are **reused** from the pool.
-  All objects (bullets, enemies, power-ups) are managed using an object pooling system.

---

##  Features

-  **Bullet Pooling**: Bullets are reused instead of instantiated repeatedly.
-  **Enemy Pooling**: Enemy ships are pulled from the pool and reset on death.
-  **Generic Pool Manager**: A flexible pooling system that can be reused for any object type.
-  **Performance Boost**: Reduced memory allocation and improved frame stability.

---

## Technologies Used

- **Unity Engine**
- **C#**
- **Object Pooling Design Pattern**
- **SOLID Principles (Single Responsibility, Dependency Inversion)**

---

## Key Takeaways

-  Improved performance through efficient object reuse.
-  Developed scalable systems for real-time games.
